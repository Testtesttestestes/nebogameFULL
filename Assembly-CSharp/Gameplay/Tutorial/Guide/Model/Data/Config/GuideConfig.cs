using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	public class GuideConfig
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x6CEF", Offset = "0x6CEF", VA = "0x6CEF")]
		public GuideConfig(in GuideId id, TutorialStepDic stepDic)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58495 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28759);
		    DAT_ram_00a58495 = '\x01';
		  }
		  param1_00 = StringLiteral_28759;
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 == 0) {
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x20),0);
		    if (iVar1 == 0) {
		      param1_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x20);
		    }
		    iVar1 = func_ii_5995(param1_00,Method_UnityEngine_JsonUtility_FromJson_StepLayoutConfig___);
		    *(int *)(param1 + 0x14) = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004D0")]
		public StepLayoutConfig StepLayoutConfig
		{
			[Token(Token = "0x6001B71")]
			[Address(RVA = "0x6CF0", Offset = "0x6CF0", VA = "0x6CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x8")]
		public readonly GuideId Id;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x10")]
		public readonly TutorialStepDic StepDic;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x14")]
		private StepLayoutConfig _stepLayoutConfig;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_StepLayoutConfig ---
		void Gameplay_Tutorial_Guide_Model_Data_Config_GuideConfig__get_StepLayoutConfig
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58496 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58496 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
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

}
