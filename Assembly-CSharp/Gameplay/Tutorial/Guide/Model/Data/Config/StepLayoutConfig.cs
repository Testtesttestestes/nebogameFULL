using System;
using System.Runtime.CompilerServices;
using Gameplay.TutorialV2.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	[Serializable]
	public class StepLayoutConfig
	{
		// Token: 0x14000133 RID: 307
		// (add) Token: 0x06001B72 RID: 7026 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001B73 RID: 7027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000133")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0x6CF1", Offset = "0x6CF1", VA = "0x6CF1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x6CF2", Offset = "0x6CF2", VA = "0x6CF2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x6CF3", Offset = "0x6CF3", VA = "0x6CF3")]
		public void OnChanged()
		{
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x6CF4", Offset = "0x6CF4", VA = "0x6CF4", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		int * Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__ToString
		                (undefined4 param1,undefined4 param2)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a58498 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig_TypeInfo);
		    DAT_ram_00a58498 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1419(param1);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig_TypeInfo + 0xb8)
		        ) || (*(int *)(*(int *)(*param1_00 + 100) +
		                       (uint)*(byte *)(
		                                      Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig_TypeInfo
		                                      + 0xb8) * 4 + -4) !=
		              Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x6CF5", Offset = "0x6CF5", VA = "0x6CF5")]
		public StepLayoutConfig Clone()
		{
		/* --- GHIDRA: Clone ---
		void Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__Clone(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = 0x3f000000;
		  *(undefined4 *)(param1 + 0x14) = 1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x6CF6", Offset = "0x6CF6", VA = "0x6CF6")]
		public StepLayoutConfig()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig___ctor(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  *(undefined4 *)(param1 + 0x2c) = 0x3f800000;
		  *(undefined4 *)(param1 + 0x24) = 0x3f400000;
		  *(undefined8 *)(param1 + 0x1c) = 0x3f8000003f800000;
		  *(undefined8 *)(param1 + 8) = 0x100000002;
		  fVar1 = *(float *)(param1 + 0x18);
		  if (0.0 < fVar1) {
		    *(float *)(param1 + 0x20) = fVar1;
		    *(float *)(param1 + 0x1c) = fVar1;
		    *(undefined4 *)(param1 + 0x18) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x8")]
		public int Revision;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x10")]
		public uint AprId;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x14")]
		public AprLayout AprLayout;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x18")]
		public MessageBubbleView.MessageBubbleViewArgs BubbleMessageArgs;

		// Token: 0x04000EDE RID: 3806
		[Token(Token = "0x4000EDE")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float BlockY;

		// Token: 0x04000EDF RID: 3807
		[Token(Token = "0x4000EDF")]
		[FieldOffset(Offset = "0x20")]
		[Range(-0.5f, 0.5f)]
		public float BlockX;

		// Token: 0x04000EE0 RID: 3808
		[Token(Token = "0x4000EE0")]
		[FieldOffset(Offset = "0x24")]
		public TargetPointerConfig TargetPointer;

		// Token: 0x04000EE1 RID: 3809
		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x28")]
		public GraphicPointerConfig GraphicPointerConfig;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ChangedEvent ---
		void Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__add_ChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58497 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58497 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0xc,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ChangedEvent ---
		void Gameplay_Tutorial_Guide_Model_Data_Config_StepLayoutConfig__remove_ChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 8) = 1;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
