using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Rewards.Renderers.Portals
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public class PortalCurrencyRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x5EC4", Offset = "0x5EC4", VA = "0x5EC4", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		undefined4
		UI_Rewards_Renderers_Portals_PortalCurrencyRewardRenderer__HandleRewardChanged
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_PortalDicExt__GetMessage(param2,*(undefined4 *)(param1 + 0x28),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x5EC5", Offset = "0x5EC5", VA = "0x5EC5", Slot = "10")]
		protected virtual string GetIconAssetId(PortalDic dict)
		{
			return null;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x5EC6", Offset = "0x5EC6", VA = "0x5EC6")]
		public PortalCurrencyRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_Portals_PortalCurrencyRewardRenderer___ctor(int *param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  undefined8 local_8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a59a3a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59a3a = '\x01';
		  }
		  local_8 = 0;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar4 = (int *)func_ii_7225(uVar3,0);
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8))
		      {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x810b2702;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b2702:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  uVar2 = 0;
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810b2780;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810b2780:
		  iVar8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  if (0 < iVar8) {
		    do {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		      piVar4 = (int *)func_ii_7225(uVar3,0);
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar6) {
		            puVar5 = (uint *)(piVar6[1] * 8 + iVar9 + 0xd0);
		            goto code_r0x810b281f;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b281f:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar6) {
		            puVar5 = (uint *)(iVar9 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x810b289d;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b289d:
		      lVar1 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,iVar7,puVar5[1]);
		      if (0 < lVar1) {
		        piVar4 = (int *)param1[5];
		        iVar9 = param1[4];
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xf4));
		        iVar10 = *piVar4;
		        uVar3 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0xe8) * 4))
		                          (piVar4,iVar9,uVar3,*(undefined4 *)(iVar10 + 0xec));
		        piVar4 = (int *)func_ii_5677(uVar3,
		                                     Method_UnityEngine_Component_GetComponent_IconValueRender___);
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xf4));
		        piVar6 = (int *)func_ii_7225(uVar3,0);
		        iVar9 = *piVar6;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar11) {
		              puVar5 = (uint *)(piVar11[1] * 8 + iVar9 + 0xd0);
		              goto code_r0x810b297c;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b297c:
		        piVar6 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        iVar9 = *piVar6;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IList_long__TypeInfo == *piVar11) {
		              puVar5 = (uint *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x810b29fa;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b29fa:
		        local_8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,iVar7,puVar5[1]);
		        iVar9 = UnityEngine_GameObject__SetActive(&local_8,0);
		        if (iVar9 == 0) {
		          iVar9 = StringLiteral_5;
		        }
		        iVar10 = System_Collections_CollectionBase___ctor(piVar4[0xc],iVar9,0);
		        if (iVar10 == 0) {
		          piVar4[0xc] = iVar9;
		          (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x114));
		        }
		      }
		      iVar7 = iVar7 + 1;
		    } while (iVar7 != iVar8);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PortalDic.Types.ContentResource _iconResourceIdx;
	}
}
