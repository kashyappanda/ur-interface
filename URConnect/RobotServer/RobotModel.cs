﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RobotServer.Types;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace RobotServer
{
    


    public enum ConnectionState : int
    {
        Error = 0,
        Disconnected = 1,
        Connected = 2,
        Paused = 3,
        Started = 4
    }

    public enum RobotMode : uint
    {
        DISCONNECTED = 0,
        CONFIRM_SAFETY = 1,
        BOOTING = 2,
        POWER_OFF = 3,
        POWER_ON = 4,
        IDLE = 5,
        BACKDRIVE = 6,
        RUNNING = 7,
        UPDATING_FIRMWARE = 8
    }

    public enum SafetyMode : uint
    {
        NORMAL = 1,
        REDUCED = 2,
        PROTECTIVE_STOP = 3,
        RECOVERY = 4,
        SAFEGUARD_STOP = 5,
        SYSTEM_EMERGENCY_STOP = 6,
        ROBOT_EMERGENCY_STOP = 7,
        VIOLATION = 8,
        FAULT = 9
    }

    public enum JointMode : int
    {
        ShuttingDown = 236,
        PartDCalibration = 237,
        BackDrive = 238,
        PowerOff = 239,
        NotResponding = 245,
        MotorInitialization = 246,
        Booting = 247,
        PartDCalibrationError = 248,
        Bootloader = 249,
        Calibration = 250,
        Fault = 252,
        Running = 253,
        Idle = 255
    }

    public class RobotModel
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(RobotModel));
        private bool _digitalOutputBit0;
        private bool _digitalOutputBit1;
        private bool _digitalOutputBit2;
        private bool _digitalOutputBit3;
        private bool _digitalOutputBit4;
        private bool _digitalOutputBit5;
        private bool _digitalOutputBit6;
        private bool _digitalOutputBit7;
        private Vector6D _actualTCPPose;
        private RobotMode _robotMode;
        private SafetyMode _safetyMode;
        private int _rtdeProtocolVersion;
        private Vector6D _targetQ;
        private double _vector6DPrecision = 0.00001;
        private Vector6D _targetQD;
        private Vector6D _targetQDD;
        private Vector6D _targetCurrent;
        private Vector6D _targetMoment;
        private Vector6D _actualQ;
        private Vector6D _actualQD;
        private Vector6D _actualCurrent;
        private bool _digitalInputBit0;
        private bool _digitalInputBit1;
        private bool _digitalInputBit2;
        private bool _digitalInputBit3;
        private bool _digitalInputBit4;
        private bool _digitalInputBit5;
        private bool _digitalInputBit6;
        private bool _digitalInputBit7;

        public string Password { get; set; }

        public IPAddress IpAddress { get; set; }

        public double RobotTimestamp
        {
            get; set;
        }

        public ConnectionState RTDEConnectionState { get; set; }




        #region Digital Input Bits

        public bool DigitalInputBit0
        {
            get { return _digitalInputBit0; }
            set
            {
                if (value != _digitalInputBit0)
                {
                    _digitalInputBit0 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit0, {_digitalInputBit0}");
                }
            }
        }

        public bool DigitalInputBit1
        {
            get { return _digitalInputBit1; }
            set
            {
                if (value != _digitalInputBit1)
                {
                    _digitalInputBit1 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit1, {_digitalInputBit1}");
                }
            }
        }

        public bool DigitalInputBit2
        {
            get { return _digitalInputBit2; }
            set
            {
                if (value != _digitalInputBit2)
                {
                    _digitalInputBit2 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit2, {_digitalInputBit2}");
                }
            }
        }

        public bool DigitalInputBit3
        {
            get { return _digitalInputBit3; }
            set
            {
                if (value != _digitalInputBit3)
                {
                    _digitalInputBit3 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit3, {_digitalInputBit3}");
                }
            }
        }

        public bool DigitalInputBit4
        {
            get { return _digitalInputBit4; }
            set
            {
                if (value != _digitalInputBit4)
                {
                    _digitalInputBit4 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit4, {_digitalInputBit4}");
                }
            }
        }

        public bool DigitalInputBit5
        {
            get { return _digitalInputBit5; }
            set
            {
                if (value != _digitalInputBit5)
                {
                    _digitalInputBit5 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit5, {_digitalInputBit5}");
                }
            }
        }

        public bool DigitalInputBit6
        {
            get { return _digitalInputBit6; }
            set
            {
                if (value != _digitalInputBit6)
                {
                    _digitalInputBit6 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit6, {_digitalInputBit6}");
                }
            }
        }

        public bool DigitalInputBit7
        {
            get { return _digitalInputBit7; }
            set
            {
                if (value != _digitalInputBit7)
                {
                    _digitalInputBit7 = value;
                    log.Info($"{RobotTimestamp} ,DigitalInputBit7, {_digitalInputBit7}");
                }
            }
        }


        #endregion





        #region Digital Output Bits

        public bool DigitalOutputBit0
        {
            get { return _digitalOutputBit0; }
            set
            {
                if (value != _digitalOutputBit0)
                {
                    _digitalOutputBit0 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit0, {_digitalOutputBit0}");
                }
            }
        }
            
        public bool DigitalOutputBit1
        {
            get { return _digitalOutputBit1; }
            set
            {
                if (value != _digitalOutputBit1)
                {
                    _digitalOutputBit1 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit1, {_digitalOutputBit1}");
                }
            }
        }

        public bool DigitalOutputBit2
        {
            get { return _digitalOutputBit2; }
            set
            {
                if (value != _digitalOutputBit2)
                {
                    _digitalOutputBit2 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit2, {_digitalOutputBit2}");
                }
            }
        }

        public bool DigitalOutputBit3
        {
            get { return _digitalOutputBit3; }
            set
            {
                if (value != _digitalOutputBit3)
                {
                    _digitalOutputBit3 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit3, {_digitalOutputBit3}");
                }
            }
        }

        public bool DigitalOutputBit4
        {
            get { return _digitalOutputBit4; }
            set
            {
                if (value != _digitalOutputBit4)
                {
                    _digitalOutputBit4 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit4, {_digitalOutputBit4}");
                }
            }
        }

        public bool DigitalOutputBit5
        {
            get { return _digitalOutputBit5; }
            set
            {
                if (value != _digitalOutputBit5)
                {
                    _digitalOutputBit5 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit5, {_digitalOutputBit5}");
                }
            }
        }

        public bool DigitalOutputBit6
        {
            get { return _digitalOutputBit6; }
            set
            {
                if (value != _digitalOutputBit6)
                {
                    _digitalOutputBit6 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit6, {_digitalOutputBit6}");
                }
            }
        }

        public bool DigitalOutputBit7
        {
            get { return _digitalOutputBit7; }
            set
            {
                if (value != _digitalOutputBit7)
                {
                    _digitalOutputBit7 = value;
                    log.Info($"{RobotTimestamp} ,DigitalOutputBit7, {_digitalOutputBit7}");
                }
            }
        }


        #endregion



        public int RTDEProtocolVersion
        {
            get { return _rtdeProtocolVersion; }
            set {
                if (_rtdeProtocolVersion != value)
                {
                    _rtdeProtocolVersion = value;
                    log.Info(RobotTimestamp + " ,RTDEProtocolVersion: " + _rtdeProtocolVersion);
                }
            }
        }

        public Vector6D ActualTCPPose
        {
            get { return _actualTCPPose; }
            set
            {
                if (!Vector6DEquals(_actualTCPPose, value, _vector6DPrecision))
                {
                    _actualTCPPose = value;
                    log.Info($"{RobotTimestamp}, ActualTCPPose,{_actualTCPPose.X}, {_actualTCPPose.Y}, {_actualTCPPose.Z}, {_actualTCPPose.RX}, {_actualTCPPose.RY}, {_actualTCPPose.RZ}");
                }
            }
        }

        public RobotMode RobotMode
        {
            get { return _robotMode; }
            set
            {
                if (_robotMode!= value)
                {
                    _robotMode = value;
                    log.Info(RobotTimestamp + " ,Robotmode, " + _robotMode);
                }
            }
        }

        public SafetyMode SafetyMode
        {
            get { return _safetyMode; }
            set {
                if (_safetyMode != value)
                {
                    _safetyMode = value;
                    log.Info(RobotTimestamp +" ,SafetyMode, " + _safetyMode);
                }
            }
        }

        public Vector6D TargetQ
        {
            get { return _targetQ; }
            set
            {
                if (!Vector6DEquals(_targetQ, value, _vector6DPrecision))
                {
                    _targetQ = value;
                    log.Info($"{RobotTimestamp}, TargetQ,{_targetQ.X}, {_targetQ.Y}, {_targetQ.Z}, {_targetQ.RX}, {_targetQ.RY}, {_targetQ.RZ}");
                }
            }
        }

        public Vector6D TargetQD
        {
            get { return _targetQD; }
            set
            {
                if (!Vector6DEquals(_targetQD, value, _vector6DPrecision))
                {
                    _targetQD = value;
                    log.Info($"{RobotTimestamp}, TargetQD,{_targetQD.X}, {_targetQD.Y}, {_targetQD.Z}, {_targetQD.RX}, {_targetQD.RY}, {_targetQD.RZ}");
                }
            }
        }

        public Vector6D TargetQDD
        {
            get { return _targetQDD; }
            set
            {
                if (!Vector6DEquals(_targetQDD, value, _vector6DPrecision))
                {
                    _targetQDD = value;
                    log.Info($"{RobotTimestamp}, TargetQDD,{_targetQDD.X}, {_targetQDD.Y}, {_targetQDD.Z}, {_targetQDD.RX}, {_targetQDD.RY}, {_targetQDD.RZ}");
                }
            }
        }

        public Vector6D TargetCurrent       //////////////////// GIVER DET MENING AT TARGET CURRENT ER VECTOR 6D ??????????????????????????
        {
            get { return _targetCurrent; }
            set
            {
                if (!Vector6DEquals(_targetCurrent, value, _vector6DPrecision))
                {
                    _targetCurrent = value;
                    log.Info($"{RobotTimestamp}, TargetCurrent,{_targetCurrent.X}, {_targetCurrent.Y}, {_targetCurrent.Z}, {_targetCurrent.RX}, {_targetCurrent.RY}, {_targetCurrent.RZ}");
                }
            }
        }

        public Vector6D TargetMoment        //////////////////// GIVER DET MENING AT TARGET Moment ER VECTOR 6D ??????????????????????????
        {
            get { return _targetMoment; }
            set
            {
                if (!Vector6DEquals(_targetMoment, value, _vector6DPrecision))
                {
                    _targetMoment = value;
                    log.Info($"{RobotTimestamp}, TargetMoment,{_targetMoment.X}, {_targetMoment.Y}, {_targetMoment.Z}, {_targetMoment.RX}, {_targetMoment.RY}, {_targetMoment.RZ}");
                }
            }
        }

        public Vector6D ActualQ
        {
            get { return _actualQ; }
            set
            {
                if (!Vector6DEquals(_actualQ, value, _vector6DPrecision))
                {
                    _actualQ = value;
                    log.Info($"{RobotTimestamp}, ActualQ,{_actualQ.X}, {_actualQ.Y}, {_actualQ.Z}, {_actualQ.RX}, {_actualQ.RY}, {_actualQ.RZ}");
                }
            }
        }

        public Vector6D ActualQD
        {
            get {return _actualQD;}
            set
            {
                if (!Vector6DEquals(_actualQD, value, _vector6DPrecision))
                {
                    _actualQD = value;
                    log.Info($"{RobotTimestamp}, ActualQD,{_actualQD.X}, {_actualQD.Y}, {_actualQD.Z}, {_actualQD.RX}, {_actualQD.RY}, {_actualQD.RZ}");
                }
            }
        }

        public Vector6D ActualCurrent
        {
            get { return _actualCurrent; }
            set
            {
                if (!Vector6DEquals(_actualCurrent, value, _vector6DPrecision))
                {
                    _actualCurrent = value;
                    log.Info($"{RobotTimestamp}, ActualCurrent,{_actualCurrent.X}, {_actualCurrent.Y}, {_actualCurrent.Z}, {_actualCurrent.RX}, {_actualCurrent.RY}, {_actualCurrent.RZ}");
                }
            }
        }

        public Vector6D JointControlOutput { get; set; }
        public Vector6D ActualTCPSpeed { get; set; }
        public Vector6D ActualTCPForce { get; set; }
        public Vector6D TargetTCPPose { get; set; }
        public Vector6D TargetTCPSpeed { get; set; }
        public Vector6D JointTemperatures { get; set; }
        public double ActualExecutionTime { get; set; }
        public Vector6D JointMode { get; set; }     //Must use jointmode enum


        private bool Vector6DEquals(Vector6D firstVector6D, Vector6D secondVector6D, double precision)
        {
            if (firstVector6D == null || secondVector6D == null)
                return false;
            if (firstVector6D.X - secondVector6D.X > precision || secondVector6D.X - firstVector6D.X > precision )
            {
                return false;
            }
            if (firstVector6D.Y - secondVector6D.Y > precision || secondVector6D.Y - firstVector6D.Y > precision)
            {
                return false;
            }
            if (firstVector6D.Z - secondVector6D.Z > precision || secondVector6D.Z - firstVector6D.Z > precision)
            {
                return false;
            }
            if (firstVector6D.RX - secondVector6D.RX > precision || secondVector6D.RX - firstVector6D.RX > precision)
            {
                return false;
            }
            if (firstVector6D.RY - secondVector6D.RY > precision || secondVector6D.RY - firstVector6D.RY > precision)
            {
                return false;
            }
            if (firstVector6D.RZ - secondVector6D.RZ > precision || secondVector6D.RZ- firstVector6D.RZ > precision)
            {
                return false;
            }
            return true;
        }
    }
}
