﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Markup;

namespace ModbusMaster
{
    public class ModbusTcp : Modbus
    {
        private TcpClient client;
        private Socket socket;

        public event ResponseData OnResponseData;

        public ushort timeout
        {
            get { return _timeout; }
            set { _timeout = value; }
        }
        public ModbusTcp(string ipAddress, int port, bool connectionType)
        {
            _ConnectionType = connectionType;
            OpenConnection(ipAddress, port, connectionType);
        }
        public bool OpenConnection(string ipAddress, int port, bool connectionType)
        {
            try
            {
                if (connectionType)
                {
                    IPAddress _ipAddress;
                    if (IPAddress.TryParse(ipAddress, out _ipAddress) == false)
                    {
                        IPHostEntry hst = Dns.GetHostEntry(ipAddress);
                        ipAddress = hst.AddressList[0].ToString();
                    }

                    socket = new Socket(IPAddress.Parse(ipAddress).AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.SendTimeout, _timeout);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, _timeout);
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.NoDelay, 1);
                }

                Connected = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Connected = false;
            }
            return Connected;
        }
        public override void SendPacket()
        {
            //if the connection is async send packet, trigger when the server response
            if (_ConnectionType)
            {
                socket.BeginSend(this.MessageSendSlave, 0, this.MessageSendSlave.Length, SocketFlags.None, new AsyncCallback(OnSend), null);
            }
            else
            {
                socket.Send(this.MessageSendSlave);
                GetResponse();
            }
        }
        public override void BuildPacket(byte slaveId, byte functionCode, int startAddress, int numAddress)
        {
            List<byte> pdu = BuildPdu(functionCode, startAddress, numAddress);
            List<byte> mbapHeader = BuildMbapHeader(slaveId, pdu.Count(), startAddress);
            this.MessageSendSlave = mbapHeader.Concat(pdu).ToArray();
        }
        public override void BuildPacket(byte slaveId, byte functionCode, int startAddress, int[] numAddress)
        {
            List<byte> pdu = BuildPdu(functionCode, startAddress, numAddress);
            List<byte> mbapHeader = BuildMbapHeader(slaveId, pdu.Count(), startAddress);
            this.MessageSendSlave = mbapHeader.Concat(pdu).ToArray();
        }
        public List<byte> BuildMbapHeader(byte slaveId, int lenghtPacket, int startAddress)
        {
            //MBPA HEADER = TRNSITION ID + PROTOCOL ID + LENGHT + UNITID
            //oltre che alla lunghezza della pdu bisogna contare anche la lunghezza dello slave;
            lenghtPacket = lenghtPacket + 1;
            List<byte> mbapHeader = new List<byte>
            {
                (byte)(startAddress >> 8),                          //transition id high byte
                (byte)startAddress,                          //transition id low byte      //DA MOFIFICARE
                0,                          //protocol id high byte 
                0,                          //protocol id low byte modbus = 0
                (byte)(lenghtPacket >> 8),  //length high byte
                (byte)(lenghtPacket),       //length low byte
                (byte)(slaveId)             //slave id
            };
            return mbapHeader;
        }
        private void OnSend(System.IAsyncResult result)
        {
            socket.BeginReceive(ResponseFromSlave, 0, ResponseFromSlave.Length, SocketFlags.None, new AsyncCallback(OnReceive), socket);
        }
        private void OnReceive(System.IAsyncResult result)
        {
            socket.EndReceive(result);
            ushort id = SwapUInt16(BitConverter.ToUInt16(ResponseFromSlave, 0));
            byte unit = ResponseFromSlave[6];
            byte function = ResponseFromSlave[7];
            byte[] data;

            if(function >= 5)
            {
                data = new byte[2];
                Array.Copy(ResponseFromSlave, 10, data, 0, 2);
            }
            else
            {
                DataRecived = new byte[ResponseFromSlave[8]];
                Array.Copy(ResponseFromSlave, 9, DataRecived, 0, ResponseFromSlave[8]);
                this.OnResponseData(ResponseFromSlave);
            }
            
        }
        private UInt16 SwapUInt16(UInt16 inValue)
        {
            return (UInt16)(((inValue & 0xff00) >> 8) |
                     ((inValue & 0x00ff) << 8));
        }
        public override void GetResponse()
        {
            //code for reving sync data

        }
    }
}
