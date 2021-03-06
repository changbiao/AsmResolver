﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#pragma warning disable 1591

namespace TUP.AsmResolver.NET.Specialized.MSIL
{
    public static class MSILOpCodes
    {
        public static readonly MSILOpCode Nop = new MSILOpCode("nop", new byte[] { 0x00 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Break = new MSILOpCode("break", new byte[] { 0x01 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldarg_0 = new MSILOpCode("ldarg.0", new byte[] { 0x02 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldarg_1 = new MSILOpCode("ldarg.1", new byte[] { 0x03 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldarg_2 = new MSILOpCode("ldarg.2", new byte[] { 0x04 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldarg_3 = new MSILOpCode("ldarg.3", new byte[] { 0x05 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldloc_0 = new MSILOpCode("ldloc.0", new byte[] { 0x06 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldloc_1 = new MSILOpCode("ldloc.1", new byte[] { 0x07 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldloc_2 = new MSILOpCode("ldloc.2", new byte[] { 0x08 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldloc_3 = new MSILOpCode("ldloc.3", new byte[] { 0x09 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Stloc_0 = new MSILOpCode("stloc.0", new byte[] { 0x0A }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Stloc_1 = new MSILOpCode("stloc.1", new byte[] { 0x0B }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Stloc_2 = new MSILOpCode("stloc.2", new byte[] { 0x0C }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Stloc_3 = new MSILOpCode("stloc.3", new byte[] { 0x0D }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Ldarg_S = new MSILOpCode("ldarg.s", new byte[] { 0x0E }, OperandType.ShortArgument, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldarga_S = new MSILOpCode("ldarga.s", new byte[] { 0x0F }, OperandType.ShortArgument, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Starg_S = new MSILOpCode("starg.s", new byte[] { 0x10 }, OperandType.ShortArgument, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Ldloc_S = new MSILOpCode("ldloc.s", new byte[] { 0x11 }, OperandType.ShortVariable, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldloca_S = new MSILOpCode("ldloca.s", new byte[] { 0x12 }, OperandType.ShortVariable, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Stloc_S = new MSILOpCode("stloc.s", new byte[] { 0x13 }, OperandType.ShortVariable, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Ldnull = new MSILOpCode("ldnull", new byte[] { 0x14 }, OperandType.None, StackBehaviour.Pushref | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_M1 = new MSILOpCode("ldc.i4.m1", new byte[] { 0x15 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_0 = new MSILOpCode("ldc.i4.0", new byte[] { 0x16 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_1 = new MSILOpCode("ldc.i4.1", new byte[] { 0x17 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_2 = new MSILOpCode("ldc.i4.2", new byte[] { 0x18 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_3 = new MSILOpCode("ldc.i4.3", new byte[] { 0x19 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_4 = new MSILOpCode("ldc.i4.4", new byte[] { 0x1A }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_5 = new MSILOpCode("ldc.i4.5", new byte[] { 0x1B }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_6 = new MSILOpCode("ldc.i4.6", new byte[] { 0x1C }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_7 = new MSILOpCode("ldc.i4.7", new byte[] { 0x1D }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_8 = new MSILOpCode("ldc.i4.8", new byte[] { 0x1E }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4_S = new MSILOpCode("ldc.i4.s", new byte[] { 0x1F }, OperandType.Int8, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I4 = new MSILOpCode("ldc.i4", new byte[] { 0x20 }, OperandType.Int32, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_I8 = new MSILOpCode("ldc.i8", new byte[] { 0x21 }, OperandType.Int64, StackBehaviour.Pushi8 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_R4 = new MSILOpCode("ldc.r4", new byte[] { 0x22 }, OperandType.Float32, StackBehaviour.Pushr4 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldc_R8 = new MSILOpCode("ldc.r8", new byte[] { 0x23 }, OperandType.Float64, StackBehaviour.Pushr8 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Dup = new MSILOpCode("dup", new byte[] { 0x25 }, OperandType.None, StackBehaviour.Push1_push1 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Pop = new MSILOpCode("pop", new byte[] { 0x26 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Jmp = new MSILOpCode("jmp", new byte[] { 0x27 }, OperandType.Method, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Call = new MSILOpCode("call", new byte[] { 0x28 }, OperandType.Method, StackBehaviour.Varpush | StackBehaviour.Varpop);
        public static readonly MSILOpCode Calli = new MSILOpCode("calli", new byte[] { 0x29 }, OperandType.Method, StackBehaviour.Varpush | StackBehaviour.Varpop);
        public static readonly MSILOpCode Ret = new MSILOpCode("ret", new byte[] { 0x2A }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Varpop);
        public static readonly MSILOpCode Br_S = new MSILOpCode("br.s", new byte[] { 0x2B }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Brfalse_S = new MSILOpCode("brfalse.s", new byte[] { 0x2C }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Brtrue_S = new MSILOpCode("brtrue.s", new byte[] { 0x2D }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Beq_S = new MSILOpCode("beq.s", new byte[] { 0x2E }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bge_S = new MSILOpCode("bge.s", new byte[] { 0x2F }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bgt_S = new MSILOpCode("bgt.s", new byte[] { 0x30 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Ble_S = new MSILOpCode("ble.s", new byte[] { 0x31 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Blt_S = new MSILOpCode("blt.s", new byte[] { 0x32 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bne_Un_S = new MSILOpCode("bne.un.s", new byte[] { 0x33 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bge_Un_S = new MSILOpCode("bge.un.s", new byte[] { 0x34 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bgt_Un_S = new MSILOpCode("bgt.un.s", new byte[] { 0x35 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Ble_Un_S = new MSILOpCode("ble.un.s", new byte[] { 0x36 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Blt_Un_S = new MSILOpCode("blt.un.s", new byte[] { 0x37 }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Br = new MSILOpCode("br", new byte[] { 0x38 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Brfalse = new MSILOpCode("brfalse", new byte[] { 0x39 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Brtrue = new MSILOpCode("brtrue", new byte[] { 0x3A }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Beq = new MSILOpCode("beq", new byte[] { 0x3B }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bge = new MSILOpCode("bge", new byte[] { 0x3C }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bgt = new MSILOpCode("bgt", new byte[] { 0x3D }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Ble = new MSILOpCode("ble", new byte[] { 0x3E }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Blt = new MSILOpCode("blt", new byte[] { 0x3F }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bne_Un = new MSILOpCode("bne.un", new byte[] { 0x40 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bge_Un = new MSILOpCode("bge.un", new byte[] { 0x41 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Bgt_Un = new MSILOpCode("bgt.un", new byte[] { 0x42 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Ble_Un = new MSILOpCode("ble.un", new byte[] { 0x43 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Blt_Un = new MSILOpCode("blt.un", new byte[] { 0x44 }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Switch = new MSILOpCode("switch", new byte[] { 0x45 }, OperandType.InstructionTable, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_I1 = new MSILOpCode("ldind.i1", new byte[] { 0x46 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_U1 = new MSILOpCode("ldind.u1", new byte[] { 0x47 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_I2 = new MSILOpCode("ldind.i2", new byte[] { 0x48 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_U2 = new MSILOpCode("ldind.u2", new byte[] { 0x49 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_I4 = new MSILOpCode("ldind.i4", new byte[] { 0x4A }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_U4 = new MSILOpCode("ldind.u4", new byte[] { 0x4B }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_I8 = new MSILOpCode("ldind.i8", new byte[] { 0x4C }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_I = new MSILOpCode("ldind.i", new byte[] { 0x4D }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_R4 = new MSILOpCode("ldind.r4", new byte[] { 0x4E }, OperandType.None, StackBehaviour.Pushr4 | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_R8 = new MSILOpCode("ldind.r8", new byte[] { 0x4F }, OperandType.None, StackBehaviour.Pushr8 | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldind_Ref = new MSILOpCode("ldind.ref", new byte[] { 0x50 }, OperandType.None, StackBehaviour.Pushref | StackBehaviour.Popi);
        public static readonly MSILOpCode Stind_Ref = new MSILOpCode("stind.ref", new byte[] { 0x51 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Stind_I1 = new MSILOpCode("stind.i1", new byte[] { 0x52 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Stind_I2 = new MSILOpCode("stind.i2", new byte[] { 0x53 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Stind_I4 = new MSILOpCode("stind.i4", new byte[] { 0x54 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Stind_I8 = new MSILOpCode("stind.i8", new byte[] { 0x55 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi8);
        public static readonly MSILOpCode Stind_R4 = new MSILOpCode("stind.r4", new byte[] { 0x56 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popr4);
        public static readonly MSILOpCode Stind_R8 = new MSILOpCode("stind.r8", new byte[] { 0x57 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popr8);
        public static readonly MSILOpCode Add = new MSILOpCode("add", new byte[] { 0x58 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Sub = new MSILOpCode("sub", new byte[] { 0x59 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Mul = new MSILOpCode("mul", new byte[] { 0x5A }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Div = new MSILOpCode("div", new byte[] { 0x5B }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Div_Un = new MSILOpCode("div.un", new byte[] { 0x5C }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Rem = new MSILOpCode("rem", new byte[] { 0x5D }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Rem_Un = new MSILOpCode("rem.un", new byte[] { 0x5E }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode And = new MSILOpCode("and", new byte[] { 0x5F }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Or = new MSILOpCode("or", new byte[] { 0x60 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Xor = new MSILOpCode("xor", new byte[] { 0x61 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Shl = new MSILOpCode("shl", new byte[] { 0x62 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Shr = new MSILOpCode("shr", new byte[] { 0x63 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Shr_Un = new MSILOpCode("shr.un", new byte[] { 0x64 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Neg = new MSILOpCode("neg", new byte[] { 0x65 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Not = new MSILOpCode("not", new byte[] { 0x66 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_I1 = new MSILOpCode("conv.i1", new byte[] { 0x67 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_I2 = new MSILOpCode("conv.i2", new byte[] { 0x68 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_I4 = new MSILOpCode("conv.i4", new byte[] { 0x69 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_I8 = new MSILOpCode("conv.i8", new byte[] { 0x6A }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_R4 = new MSILOpCode("conv.r4", new byte[] { 0x6B }, OperandType.None, StackBehaviour.Pushr4 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_R8 = new MSILOpCode("conv.r8", new byte[] { 0x6C }, OperandType.None, StackBehaviour.Pushr8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_U4 = new MSILOpCode("conv.u4", new byte[] { 0x6D }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_U8 = new MSILOpCode("conv.u8", new byte[] { 0x6E }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Callvirt = new MSILOpCode("callvirt", new byte[] { 0x6F }, OperandType.Method, StackBehaviour.Varpush | StackBehaviour.Varpop);
        public static readonly MSILOpCode Cpobj = new MSILOpCode("cpobj", new byte[] { 0x70 }, OperandType.Type, StackBehaviour.Push0 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Ldobj = new MSILOpCode("ldobj", new byte[] { 0x71 }, OperandType.Type, StackBehaviour.Push1 | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldstr = new MSILOpCode("ldstr", new byte[] { 0x72 }, OperandType.String, StackBehaviour.Pushref | StackBehaviour.Pop0);
        public static readonly MSILOpCode Newobj = new MSILOpCode("newobj", new byte[] { 0x73 }, OperandType.Method, StackBehaviour.Pushref | StackBehaviour.Varpop);
        public static readonly MSILOpCode Castclass = new MSILOpCode("castclass", new byte[] { 0x74 }, OperandType.Type, StackBehaviour.Pushref | StackBehaviour.Popref);
        public static readonly MSILOpCode Isinst = new MSILOpCode("isinst", new byte[] { 0x75 }, OperandType.Type, StackBehaviour.Pushi | StackBehaviour.Popref);
        public static readonly MSILOpCode Conv_R_Un = new MSILOpCode("conv.r.un", new byte[] { 0x76 }, OperandType.None, StackBehaviour.Pushr8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Unbox = new MSILOpCode("unbox", new byte[] { 0x79 }, OperandType.Type, StackBehaviour.Pushi | StackBehaviour.Popref);
        public static readonly MSILOpCode Throw = new MSILOpCode("throw", new byte[] { 0x7A }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref);
        public static readonly MSILOpCode Ldfld = new MSILOpCode("ldfld", new byte[] { 0x7B }, OperandType.Field, StackBehaviour.Push1 | StackBehaviour.Popref);
        public static readonly MSILOpCode Ldflda = new MSILOpCode("ldflda", new byte[] { 0x7C }, OperandType.Field, StackBehaviour.Pushi| StackBehaviour.Popref);
        public static readonly MSILOpCode Stfld = new MSILOpCode("stfld", new byte[] { 0x7D }, OperandType.Field, StackBehaviour.Push0 | StackBehaviour.Popref_pop1);
        public static readonly MSILOpCode Ldsfld = new MSILOpCode("ldsfld", new byte[] { 0x7E }, OperandType.Field, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldsflda = new MSILOpCode("ldsflda", new byte[] { 0x7F }, OperandType.Field, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Stsfld = new MSILOpCode("stsfld", new byte[] { 0x80 }, OperandType.Field, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Stobj = new MSILOpCode("stobj", new byte[] { 0x81 }, OperandType.Type, StackBehaviour.Push0 | StackBehaviour.Popi_pop1);
        public static readonly MSILOpCode Conv_Ovf_I1_Un = new MSILOpCode("conv.ovf.i1.un", new byte[] { 0x82 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I2_Un = new MSILOpCode("conv.ovf.i2.un", new byte[] { 0x83 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I4_Un = new MSILOpCode("conv.ovf.i4.un", new byte[] { 0x84 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I8_Un = new MSILOpCode("conv.ovf.i8.un", new byte[] { 0x85 }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U1_Un = new MSILOpCode("conv.ovf.u1.un", new byte[] { 0x86 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U2_Un = new MSILOpCode("conv.ovf.u2.un", new byte[] { 0x87 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U4_Un = new MSILOpCode("conv.ovf.u4.un", new byte[] { 0x88 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U8_Un = new MSILOpCode("conv.ovf.u8.un", new byte[] { 0x89 }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I_Un = new MSILOpCode("conv.ovf.i.un", new byte[] { 0x8A }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U_Un = new MSILOpCode("conv.ovf.u.un", new byte[] { 0x8B }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Box = new MSILOpCode("box", new byte[] { 0x8C }, OperandType.Type, StackBehaviour.Pushref | StackBehaviour.Pop1);
        public static readonly MSILOpCode Newarr = new MSILOpCode("newarr", new byte[] { 0x8D }, OperandType.Type, StackBehaviour.Pushref | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldlen = new MSILOpCode("ldlen", new byte[] { 0x8E }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref);
        public static readonly MSILOpCode Ldelema = new MSILOpCode("ldelema", new byte[] { 0x8F }, OperandType.Type, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_I1 = new MSILOpCode("ldelem.i1", new byte[] { 0x90 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_U1 = new MSILOpCode("ldelem.u1", new byte[] { 0x91 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_I2 = new MSILOpCode("ldelem.i2", new byte[] { 0x92 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_U2 = new MSILOpCode("ldelem.u2", new byte[] { 0x93 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_I4 = new MSILOpCode("ldelem.i4", new byte[] { 0x94 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_U4 = new MSILOpCode("ldelem.u4", new byte[] { 0x95 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_I8 = new MSILOpCode("ldelem.i8", new byte[] { 0x96 }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_I = new MSILOpCode("ldelem.i", new byte[] { 0x97 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_R4 = new MSILOpCode("ldelem.r4", new byte[] { 0x98 }, OperandType.None, StackBehaviour.Pushr4 | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_R8 = new MSILOpCode("ldelem.r8", new byte[] { 0x99 }, OperandType.None, StackBehaviour.Pushr8 | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Ldelem_Ref = new MSILOpCode("ldelem.ref", new byte[] { 0x9A }, OperandType.None, StackBehaviour.Pushref | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Stelem_I = new MSILOpCode("stelem.i", new byte[] { 0x9B }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popi);
        public static readonly MSILOpCode Stelem_I1 = new MSILOpCode("stelem.i1", new byte[] { 0x9C }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popi);
        public static readonly MSILOpCode Stelem_I2 = new MSILOpCode("stelem.i2", new byte[] { 0x9D }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popi);
        public static readonly MSILOpCode Stelem_I4 = new MSILOpCode("stelem.i4", new byte[] { 0x9E }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popi);
        public static readonly MSILOpCode Stelem_I8 = new MSILOpCode("stelem.i8", new byte[] { 0x9F }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popi8);
        public static readonly MSILOpCode Stelem_R4 = new MSILOpCode("stelem.r4", new byte[] { 0xA0 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popr4);
        public static readonly MSILOpCode Stelem_R8 = new MSILOpCode("stelem.r8", new byte[] { 0xA1 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popr8);
        public static readonly MSILOpCode Stelem_Ref = new MSILOpCode("stelem.ref", new byte[] { 0xA2 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popref_popi_popref);
        public static readonly MSILOpCode Ldelem = new MSILOpCode("ldelem", new byte[] { 0xA3 }, OperandType.Type, StackBehaviour.Push1 | StackBehaviour.Popref_popi);
        public static readonly MSILOpCode Stelem = new MSILOpCode("stelem", new byte[] { 0xA4 }, OperandType.Type, StackBehaviour.Push0 | StackBehaviour.Popref_popi_pop1);
        public static readonly MSILOpCode Unbox_Any = new MSILOpCode("unbox.any", new byte[] { 0xA5 }, OperandType.Type, StackBehaviour.Push1 | StackBehaviour.Popref);
        public static readonly MSILOpCode Conv_Ovf_I1 = new MSILOpCode("conv.ovf.i1", new byte[] { 0xB3 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U1 = new MSILOpCode("conv.ovf.u1", new byte[] { 0xB4 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I2 = new MSILOpCode("conv.ovf.i2", new byte[] { 0xB5 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U2 = new MSILOpCode("conv.ovf.u2", new byte[] { 0xB6 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I4 = new MSILOpCode("conv.ovf.i4", new byte[] { 0xB7 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U4 = new MSILOpCode("conv.ovf.u4", new byte[] { 0xB8 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I8 = new MSILOpCode("conv.ovf.i8", new byte[] { 0xB9 }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U8 = new MSILOpCode("conv.ovf.u8", new byte[] { 0xBA }, OperandType.None, StackBehaviour.Pushi8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Refanyval = new MSILOpCode("refanyval", new byte[] { 0xC2 }, OperandType.Type, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Ckfinite = new MSILOpCode("ckfinite", new byte[] { 0xC3 }, OperandType.None, StackBehaviour.Pushr8 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Mkrefany = new MSILOpCode("mkrefany", new byte[] { 0xC6 }, OperandType.Type, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Ldtoken = new MSILOpCode("ldtoken", new byte[] { 0xD0 }, OperandType.Token, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Conv_U2 = new MSILOpCode("conv.u2", new byte[] { 0xD1 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_U1 = new MSILOpCode("conv.u1", new byte[] { 0xD2 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_I = new MSILOpCode("conv.i", new byte[] { 0xD3 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_I = new MSILOpCode("conv.ovf.i", new byte[] { 0xD4 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Conv_Ovf_U = new MSILOpCode("conv.ovf.u", new byte[] { 0xD5 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Add_Ovf = new MSILOpCode("add.ovf", new byte[] { 0xD6 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Add_Ovf_Un = new MSILOpCode("add.ovf.un", new byte[] { 0xD7 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Mul_Ovf = new MSILOpCode("mul.ovf", new byte[] { 0xD8 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Mul_Ovf_Un = new MSILOpCode("mul.ovf.un", new byte[] { 0xD9 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Sub_Ovf = new MSILOpCode("sub.ovf", new byte[] { 0xDA }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Sub_Ovf_Un = new MSILOpCode("sub.ovf.un", new byte[] { 0xDB }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Endfinally = new MSILOpCode("endfinally", new byte[] { 0xDC }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Leave = new MSILOpCode("leave", new byte[] { 0xDD }, OperandType.InstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Leave_S = new MSILOpCode("leave.s", new byte[] { 0xDE }, OperandType.ShortInstructionTarget, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Stind_I = new MSILOpCode("stind.i", new byte[] { 0xDF }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi);
        public static readonly MSILOpCode Conv_U = new MSILOpCode("conv.u", new byte[] { 0xE0 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Prefix7 = new MSILOpCode("prefix7", new byte[] { 0xF8 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefix6 = new MSILOpCode("prefix6", new byte[] { 0xF9 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefix5 = new MSILOpCode("prefix5", new byte[] { 0xFA }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefix4 = new MSILOpCode("prefix4", new byte[] { 0xFB }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefix3 = new MSILOpCode("prefix3", new byte[] { 0xFC }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefix2 = new MSILOpCode("prefix2", new byte[] { 0xFD }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefix1 = new MSILOpCode("prefix1", new byte[] { 0xFE }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Prefixref = new MSILOpCode("prefixref", new byte[] { 0xFF }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Arglist = new MSILOpCode("arglist", new byte[] { 0xFE, 0x00 }, OperandType.None, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ceq = new MSILOpCode("ceq", new byte[] { 0xFE, 0x01 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Cgt = new MSILOpCode("cgt", new byte[] { 0xFE, 0x02 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Cgt_Un = new MSILOpCode("cgt.un", new byte[] { 0xFE, 0x03 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Clt = new MSILOpCode("clt", new byte[] { 0xFE, 0x04 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Clt_Un = new MSILOpCode("clt.un", new byte[] { 0xFE, 0x05 }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1_pop1);
        public static readonly MSILOpCode Ldftn = new MSILOpCode("ldftn", new byte[] { 0xFE, 0x06 }, OperandType.Method, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldvirtftn = new MSILOpCode("ldvirtftn", new byte[] { 0xFE, 0x07 }, OperandType.Method, StackBehaviour.Pushi | StackBehaviour.Popref);
        public static readonly MSILOpCode Ldarg = new MSILOpCode("ldarg", new byte[] { 0xFE, 0x09 }, OperandType.Argument, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldarga = new MSILOpCode("ldarga", new byte[] { 0xFE, 0x0A }, OperandType.Argument, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Starg = new MSILOpCode("starg", new byte[] { 0xFE, 0x0B }, OperandType.Argument, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Ldloc = new MSILOpCode("ldloc", new byte[] { 0xFE, 0x0C }, OperandType.Variable, StackBehaviour.Push1 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Ldloca = new MSILOpCode("ldloca", new byte[] { 0xFE, 0x0D }, OperandType.Variable, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Stloc = new MSILOpCode("stloc", new byte[] { 0xFE, 0x0E }, OperandType.Variable, StackBehaviour.Push0 | StackBehaviour.Pop1);
        public static readonly MSILOpCode Localloc = new MSILOpCode("localloc", new byte[] { 0xFE, 0x0F }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Popi);
        public static readonly MSILOpCode Endfilter = new MSILOpCode("endfilter", new byte[] { 0xFE, 0x11 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Unaligned = new MSILOpCode("unaligned.", new byte[] { 0xFE, 0x12 }, OperandType.Int8, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Volatile = new MSILOpCode("volatile.", new byte[] { 0xFE, 0x13 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Tailcall = new MSILOpCode("tailcall", new byte[] { 0xFE, 0x14 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Initobj = new MSILOpCode("initobj", new byte[] { 0xFE, 0x15 }, OperandType.Type, StackBehaviour.Push0 | StackBehaviour.Popi);
        public static readonly MSILOpCode Constrained = new MSILOpCode("constrained.", new byte[] { 0xFE, 0x16 }, OperandType.Type, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Cpblk = new MSILOpCode("cpblk", new byte[] { 0xFE, 0x17 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi_popi);
        public static readonly MSILOpCode Initblk = new MSILOpCode("initblk", new byte[] { 0xFE, 0x18 }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Popi_popi_popi);
        public static readonly MSILOpCode Rethrow = new MSILOpCode("rethrow", new byte[] { 0xFE, 0x1A }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);
        public static readonly MSILOpCode Sizeof = new MSILOpCode("sizeof", new byte[] { 0xFE, 0x1C }, OperandType.Type, StackBehaviour.Pushi | StackBehaviour.Pop0);
        public static readonly MSILOpCode Refanytype = new MSILOpCode("refanytype", new byte[] { 0xFE, 0x1D }, OperandType.None, StackBehaviour.Pushi | StackBehaviour.Pop1);
        public static readonly MSILOpCode Readonly = new MSILOpCode("readonly", new byte[] { 0xFE, 0x1E }, OperandType.None, StackBehaviour.Push0 | StackBehaviour.Pop0);

    }
}
