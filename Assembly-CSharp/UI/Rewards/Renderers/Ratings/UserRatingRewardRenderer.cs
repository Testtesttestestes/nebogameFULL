using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers.Ratings
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	public class UserRatingRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x5EBF", Offset = "0x5EBF", VA = "0x5EBF", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x5EC0", Offset = "0x5EC0", VA = "0x5EC0")]
		public UserRatingRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_Ratings_UserRatingRewardRenderer___ctor(int *param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a59a38 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12149);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26172);
		    DAT_ram_00a59a38 = '\x01';
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar4 = (int *)func_ii_7225(uVar3,0);
		  iVar9 = *piVar4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8))
		      {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x810b1c3e;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1c3e:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  uVar2 = 0;
		  iVar9 = *piVar4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810b1cbc;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810b1cbc:
		  iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  if (0 < iVar9) {
		    do {
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		      piVar4 = (int *)func_ii_7225(uVar3,0);
		      iVar10 = *piVar4;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar7) {
		            puVar5 = (uint *)(piVar7[1] * 8 + iVar10 + 0xd0);
		            goto code_r0x810b1d5b;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1d5b:
		      piVar4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      iVar10 = *piVar4;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar7) {
		            puVar5 = (uint *)(iVar10 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x810b1dd9;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		      }
		      puVar5 = (uint *)func_ii_1080(piVar4,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b1dd9:
		      lVar1 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,iVar8,puVar5[1]);
		      if (0 < lVar1) {
		        piVar4 = (int *)param1[5];
		        iVar10 = param1[4];
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xf4));
		        iVar11 = *piVar4;
		        uVar3 = (**(code **)((ulonglong)*(uint *)(iVar11 + 0xe8) * 4))
		                          (piVar4,iVar10,uVar3,*(undefined4 *)(iVar11 + 0xec));
		        piVar4 = (int *)func_ii_5677(uVar3,
		                                     Method_UnityEngine_Component_GetComponent_IconValueRender___);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar10 = *piVar7;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar12) {
		              puVar5 = (uint *)(piVar12[1] * 8 + iVar10 + 0x290);
		              goto code_r0x810b1ec4;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x810b1ec4:
		        iVar10 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*(int *)(iVar10 + 0x10) + 0x3c),
		                           *(undefined4 *)(*param1 + 0x114));
		        Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar4[10],uVar3,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar3 = func_ii_7508(StringLiteral_12149,1,0,1,0,0,0,0);
		        iVar10 = Mono_Security_ASN1Convert__ToOid
		                           (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		        uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xf4));
		        piVar7 = (int *)func_ii_7225(uVar6,0);
		        iVar11 = *piVar7;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		            if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar12) {
		              puVar5 = (uint *)(piVar12[1] * 8 + iVar11 + 0xd0);
		              goto code_r0x810b1fcb;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar7,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1fcb:
		        piVar7 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar7,puVar5[1]);
		        iVar11 = *piVar7;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IList_long__TypeInfo == *piVar12) {
		              puVar5 = (uint *)(iVar11 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x810b2049;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar7,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b2049:
		        local_8 = (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar8,puVar5[1]);
		        uVar6 = func_ii_1081(DAT_ram_00a66964,&local_8);
		        uVar6 = func_ii_4419(StringLiteral_28579,uVar6,0);
		        local_10 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_10,StringLiteral_26172,uVar6,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(undefined8 *)(iVar10 + 0x10) = local_10;
		        iVar10 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                           (uVar3,iVar10,0);
		        iVar11 = System_Collections_CollectionBase___ctor(piVar4[0xc],iVar10,0);
		        if (iVar11 == 0) {
		          piVar4[0xc] = iVar10;
		          (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x110) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x114));
		        }
		      }
		      iVar8 = iVar8 + 1;
		    } while (iVar8 != iVar9);
		  }
		  return;
		}
		*/

		}
	}
}
