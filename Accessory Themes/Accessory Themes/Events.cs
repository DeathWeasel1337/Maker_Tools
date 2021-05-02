﻿using System;

namespace Accessory_Themes_and_Info
{
    public sealed class Slot_ACC_Change_ARG : EventArgs
    {
        public Slot_ACC_Change_ARG(ChaControl _Character, int _slotNo, int _Type)
        {
            Character = _Character;
            SlotNo = _slotNo;
            Type = _Type;
        }
        public ChaControl Character { get; }
        public int SlotNo { get; }
        public int Type { get; }
    }
}