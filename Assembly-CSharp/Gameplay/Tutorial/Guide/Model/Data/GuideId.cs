using System;
using Il2CppDummyDll;

namespace Gameplay.Tutorial.Guide.Model.Data
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	[Serializable]
	public struct GuideId
	{
		// Token: 0x06001B66 RID: 7014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x6CEC", Offset = "0x6CEC", VA = "0x6CEC")]
		public GuideId(uint tutorialId, uint stepId)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Tutorial_Guide_Model_Data_GuideId___ctor(undefined4 *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58494 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28658);
		    DAT_ram_00a58494 = '\x01';
		  }
		  local_4 = *param1;
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  local_8 = param1[1];
		  param3 = func_ii_1081(DAT_ram_00a66958,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28658,uVar1,param3,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x6CED", Offset = "0x6CED", VA = "0x6CED", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Gameplay_Tutorial_Guide_Model_Data_GuideId__ToString(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 8) = 1;
		  if (DAT_ram_00a65d40 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		    DAT_ram_00a65d40 = '\x01';
		  }
		  iVar1 = UnityEngine_Vector2_TypeInfo;
		  *(undefined8 *)(param1 + 0x10) = **(undefined8 **)(UnityEngine_Vector2_TypeInfo + 0x5c);
		  if (DAT_ram_00a65d3f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		    DAT_ram_00a65d3f = '\x01';
		    iVar1 = UnityEngine_Vector2_TypeInfo;
		  }
		  *(undefined8 *)(param1 + 0x18) = *(undefined8 *)(*(int *)(iVar1 + 0x5c) + 8);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04000ED0 RID: 3792
		[Token(Token = "0x4000ED0")]
		[FieldOffset(Offset = "0x0")]
		public uint TutorialId;

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		[FieldOffset(Offset = "0x4")]
		public uint StepId;
	}
}
