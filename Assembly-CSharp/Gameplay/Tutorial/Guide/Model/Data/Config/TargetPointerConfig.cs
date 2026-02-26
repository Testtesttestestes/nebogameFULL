using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	[Serializable]
	public class TargetPointerConfig
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x6CF7", Offset = "0x6CF7", VA = "0x6CF7")]
		public TargetPointerConfig()
		{
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x6CF8", Offset = "0x6CF8", VA = "0x6CF8")]
		public Vector2 GetScale()
		{
		/* --- GHIDRA: GetScale ---
		void Gameplay_Tutorial_Guide_Model_Data_Config_TargetPointerConfig__GetScale
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 param1_01;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58499 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_HandleTurnStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo);
		    DAT_ram_00a58499 = '\x01';
		  }
		  iVar3 = **(int **)(param1 + 0x10);
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		                               (*(int **)(param1 + 0x10),*(undefined4 *)(iVar3 + 0xe4));
		  param1_01 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_01,param1,
		             Method_Gameplay_Tutorial_Guide_Helpers_ArenaCombatGuideHelper_HandleTurnStateChangedEvent__
		             ,0);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x80ef4ce0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Gameplay_Combat_View_TurnDisplay_ITurnStatePointer_TypeInfo,3);
		code_r0x80ef4ce0:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1_01,puVar2[1]);
		  if (*(int *)(param1 + 0x14) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x14),0,0);
		  }
		  return;
		}
		*/

			return default(Vector2);
		}

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x8")]
		public TargetPointerShape Shape;

		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0xC")]
		public OverlapType OverlapType;

		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Offset;

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x18")]
		[Obsolete]
		public float Scale;

		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x1C")]
		public float ScaleX;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x20")]
		public float ScaleY;

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x24")]
		public float ShadeAlpha;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x28")]
		public bool OutlineDisabled;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x2C")]
		public float OutlineScale;
	}
}
