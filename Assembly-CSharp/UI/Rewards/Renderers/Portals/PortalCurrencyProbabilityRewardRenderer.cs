using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Rewards.Renderers.Portals
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	public class PortalCurrencyProbabilityRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x5EC1", Offset = "0x5EC1", VA = "0x5EC1", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x5EC2", Offset = "0x5EC2", VA = "0x5EC2", Slot = "10")]
		protected virtual string GetIconAssetId(PortalDic dict)
		{
			return null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x5EC3", Offset = "0x5EC3", VA = "0x5EC3")]
		public PortalCurrencyProbabilityRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_Portals_PortalCurrencyProbabilityRewardRenderer___ctor
		               (int *param1,undefined4 param2)
		
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
		  if (DAT_ram_00a59a39 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59a39 = '\x01';
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
		        goto code_r0x810b21ec;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b21ec:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  uVar2 = 0;
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810b226a;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810b226a:
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
		            goto code_r0x810b2309;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b2309:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar6) {
		            puVar5 = (uint *)(iVar9 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x810b2387;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b2387:
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
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar9 = *piVar6;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		              puVar5 = (uint *)(piVar11[1] * 8 + iVar9 + 0x290);
		              goto code_r0x810b2472;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x810b2472:
		        iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*(int *)(iVar9 + 0x10) + 0x3c),
		                           *(undefined4 *)(*param1 + 0x114));
		        Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar4[10],uVar3,0);
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
		              goto code_r0x810b2537;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b2537:
		        piVar6 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        iVar9 = *piVar6;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IList_long__TypeInfo == *piVar11) {
		              puVar5 = (uint *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x810b25b5;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b25b5:
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

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PortalDic.Types.ContentResource _iconResourceIdx;
	}
}
