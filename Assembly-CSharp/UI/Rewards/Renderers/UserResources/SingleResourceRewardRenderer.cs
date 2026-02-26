using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers.UserResources
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public class SingleResourceRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BA1 RID: 2977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x5EBA", Offset = "0x5EBA", VA = "0x5EBA", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x5EBB", Offset = "0x5EBB", VA = "0x5EBB")]
		public SingleResourceRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_UserResources_SingleResourceRewardRenderer___ctor
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
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a59a36 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59a36 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
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
		        goto code_r0x810b10e7;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b10e7:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  uVar2 = 0;
		  iVar8 = *piVar4;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810b1165;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810b1165:
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
		            goto code_r0x810b1204;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1204:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      iVar9 = *piVar4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar6) {
		            puVar5 = (uint *)(iVar9 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x810b1282;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b1282:
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
		              puVar5 = (uint *)(piVar11[1] * 8 + iVar9 + 0x288);
		              goto code_r0x810b136d;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x810b136d:
		        iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        iVar9 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__SetEventEntryAttempt
		                          (*(undefined4 *)(iVar9 + 0x14),&local_4,0);
		        if (iVar9 != 0) {
		          uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                            (param1,local_4,*(undefined4 *)(*param1 + 0x114));
		          Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar4[10],uVar3,0);
		        }
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
		              goto code_r0x810b1442;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1442:
		        piVar6 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		        iVar9 = *piVar6;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IList_long__TypeInfo == *piVar11) {
		              puVar5 = (uint *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x810b14c0;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b14c0:
		        local_10 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,iVar7,puVar5[1]);
		        iVar9 = UnityEngine_GameObject__SetActive(&local_10,0);
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
	}
}
