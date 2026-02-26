using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UI.Rewards.Renderers.ThemeDuel
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	public class ThemeDuelPointsRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x5EBC", Offset = "0x5EBC", VA = "0x5EBC", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		/* --- GHIDRA: HandleRewardChanged ---
		undefined4
		UI_Rewards_Renderers_ThemeDuel_ThemeDuelPointsRewardRenderer__HandleRewardChanged
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_SpellDicExt__GetTutorialDescription
		                    (param2,*(undefined4 *)(param1 + 0x28),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x5EBD", Offset = "0x5EBD", VA = "0x5EBD", Slot = "10")]
		protected virtual string GetIconAssetId(ThemeDuelDic dict)
		{
		/* --- GHIDRA: GetIconAssetId ---
		void UI_Rewards_Renderers_ThemeDuel_ThemeDuelPointsRewardRenderer__GetIconAssetId
		               (int param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(undefined4 *)(param1 + 0x28) = 0xc6;
		  local_30 = 0x3f8000003f800000;
		  local_8 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_24,&local_38,0);
		  *(undefined4 *)(param1 + 0x20) = (undefined4)local_24;
		  local_1c = 0x3f8000003f800000;
		  local_40 = 0x3f8000003f800000;
		  local_24 = 0x3f8000003f800000;
		  local_48 = 0x3f8000003f800000;
		  UnityEngine_Color32___ctor(&local_14,&local_48,0);
		  *(undefined4 *)(param1 + 0x24) = local_14;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x5EBE", Offset = "0x5EBE", VA = "0x5EBE")]
		public ThemeDuelPointsRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_ThemeDuel_ThemeDuelPointsRewardRenderer___ctor
		               (int *param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  int iVar2;
		  uint uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  int iVar10;
		  int *piVar11;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a37 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59a37 = '\x01';
		  }
		  local_8 = 0;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  piVar5 = (int *)func_ii_7225(uVar4,0);
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8))
		      {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x810b16f4;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar5,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b16f4:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		  uVar3 = 0;
		  iVar7 = *piVar5;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_long__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8)) {
		        puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810b1772;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar3);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_ICollection_long__TypeInfo,0);
		code_r0x810b1772:
		  iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		  if (0 < iVar7) {
		    iVar2 = 0;
		    do {
		      uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		      piVar5 = (int *)func_ii_7225(uVar4,0);
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar3 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		          if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar9) {
		            puVar6 = (uint *)(piVar9[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x810b1815;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1815:
		      piVar5 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar3 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		          if (System_Collections_Generic_IList_long__TypeInfo == *piVar9) {
		            puVar6 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x810b1893;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar5,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b1893:
		      lVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,iVar2,puVar6[1]);
		      if (0 < lVar1) {
		        piVar5 = (int *)param1[5];
		        iVar8 = param1[4];
		        uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xf4));
		        iVar10 = *piVar5;
		        uVar4 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0xe8) * 4))
		                          (piVar5,iVar8,uVar4,*(undefined4 *)(iVar10 + 0xec));
		        piVar5 = (int *)func_ii_5677(uVar4,
		                                     Method_UnityEngine_Component_GetComponent_IconValueRender___);
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar8 = *piVar9;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		              puVar6 = (uint *)(piVar11[1] * 8 + iVar8 + 0x178);
		              goto code_r0x810b1984;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810b1984:
		        uVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		        uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		        iVar8 = Core_Extensions_Dict_DictExt__GetExperienceDic(uVar4,iVar2 + 1,0);
		        if (iVar8 != 0) {
		          uVar4 = Gameplay_UserInfo_View_TitleIconValueBackground__SetTitle(iVar8,0);
		          Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar5[10],uVar4,0);
		        }
		        uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xf4));
		        piVar9 = (int *)func_ii_7225(uVar4,0);
		        iVar8 = *piVar9;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		            if (Core_Data_Decorators_IRewardInfo_TypeInfo == *piVar11) {
		              puVar6 = (uint *)(piVar11[1] * 8 + iVar8 + 0xd0);
		              goto code_r0x810b1a4d;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar9,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b1a4d:
		        piVar9 = (int *)(**(code **)((ulonglong)*puVar6 * 4))(piVar9,puVar6[1]);
		        iVar8 = *piVar9;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		            if (System_Collections_Generic_IList_long__TypeInfo == *piVar11) {
		              puVar6 = (uint *)(iVar8 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x810b1acb;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar9,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b1acb:
		        local_8 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,iVar2,puVar6[1]);
		        iVar8 = UnityEngine_GameObject__SetActive(&local_8,0);
		        if (iVar8 == 0) {
		          iVar8 = StringLiteral_5;
		        }
		        iVar10 = System_Collections_CollectionBase___ctor(piVar5[0xc],iVar8,0);
		        if (iVar10 == 0) {
		          piVar5[0xc] = iVar8;
		          (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x110) * 4))
		                    (piVar5,*(undefined4 *)(*piVar5 + 0x114));
		        }
		      }
		      iVar2 = iVar2 + 1;
		    } while (iVar7 != iVar2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_resourceIdx")]
		[SerializeField]
		private ThemeDuelDic.Types.ContentResource _iconResourceIdx;
	}
}
