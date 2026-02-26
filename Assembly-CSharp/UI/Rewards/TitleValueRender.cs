using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Rewards
{
	// Token: 0x0200019C RID: 412
	[Token(Token = "0x200019C")]
	public class TitleValueRender : MonoBehaviour
	{
		// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x5E83", Offset = "0x5E83", VA = "0x5E83")]
		public void Init(string title, string value)
		{
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x5E84", Offset = "0x5E84", VA = "0x5E84")]
		public TitleValueRender()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_TitleValueRender___ctor(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param3;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  uint uVar10;
		  
		  iVar6 = 0;
		  if (DAT_ram_00a59a16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AprView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a16 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar2 = (int *)func_ii_7225(uVar1,0);
		  iVar7 = *piVar2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)
		         ) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x810aa03b;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aa03b:
		  piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  uVar10 = 0;
		  iVar7 = *piVar2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		        puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810aa0b9;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810aa0b9:
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  if (0 < iVar7) {
		    do {
		      uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		      piVar2 = (int *)func_ii_7225(uVar1,0);
		      iVar8 = *piVar2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar5) {
		            puVar3 = (uint *)(piVar5[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x810aa158;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810aa158:
		      piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      iVar8 = *piVar2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar5) {
		            puVar3 = (uint *)(iVar8 + piVar5[1] * 8 + 0xc0);
		            goto code_r0x810aa1d4;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810aa1d4:
		      uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,iVar6,puVar3[1]);
		      iVar8 = param1[10];
		      uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1[4],0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      piVar2 = (int *)func_ii_6805(iVar8,uVar4,Method_UnityEngine_Object_Instantiate_AprView___);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		            puVar3 = (uint *)(piVar9[1] * 8 + iVar8 + 0x140);
		            goto code_r0x810aa2b5;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x810aa2b5:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      uVar4 = func_ii_7112(uVar4,0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar10 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar9) {
		            puVar3 = (uint *)(piVar9[1] * 8 + iVar8 + 0x178);
		            goto code_r0x810aa368;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810aa368:
		      param3 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      uVar1 = Gameplay_Aprs_Model_AprData__InvalidateUser(uVar1,uVar4,param3,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x138) * 4))
		                (piVar2,uVar1,*(undefined4 *)(*piVar2 + 0x13c));
		      iVar6 = iVar6 + 1;
		    } while (iVar6 != iVar7);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _value;
	}
}
