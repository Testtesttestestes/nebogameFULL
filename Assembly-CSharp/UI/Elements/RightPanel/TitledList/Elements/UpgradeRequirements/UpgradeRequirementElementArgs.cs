using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements.UpgradeRequirements
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public class UpgradeRequirementElementArgs
	{
		// Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x6035", Offset = "0x6035", VA = "0x6035")]
		public UpgradeRequirementElementArgs(Sprite collected, string requirement)
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_RightPanel_TitledList_Elements_UpgradeRequirements_UpgradeRequirementElementArgs___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a6396b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2169);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13094);
		    DAT_ram_00a6396b = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13094,1,0,1,0,0,0,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_2169,param2,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		[FieldOffset(Offset = "0x8")]
		public Sprite collected;

		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		[FieldOffset(Offset = "0xC")]
		public string requirement;
	}
}
