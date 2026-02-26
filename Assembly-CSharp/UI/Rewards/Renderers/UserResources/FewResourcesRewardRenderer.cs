using System;
using Il2CppDummyDll;

namespace UI.Rewards.Renderers.UserResources
{
	// Token: 0x020001B0 RID: 432
	[Token(Token = "0x20001B0")]
	public class FewResourcesRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000B9F RID: 2975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x5EB8", Offset = "0x5EB8", VA = "0x5EB8", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x5EB9", Offset = "0x5EB9", VA = "0x5EB9")]
		public FewResourcesRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Rewards_Renderers_UserResources_FewResourcesRewardRenderer___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 in_register_20000014;
		  undefined8 uVar3;
		  uint uVar5;
		  longlong lVar4;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  uint *puVar8;
		  undefined4 param2_00;
		  longlong lVar9;
		  double dVar10;
		  int *piVar11;
		  int *piVar12;
		  int iVar13;
		  uint uVar14;
		  double dVar15;
		  int iVar16;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a35 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IconValueRender___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_IRewardInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a59a35 = '\x01';
		  }
		  local_8 = 0;
		  piVar11 = (int *)param1[5];
		  iVar13 = param1[4];
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  uVar3 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4));
		  uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(uVar1,uVar3);
		  iVar16 = *piVar11;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),piVar11);
		  uVar3 = CONCAT44((int)((ulonglong)uVar3 >> 0x20),iVar13);
		  uVar7 = (**(code **)((ulonglong)*(uint *)(iVar16 + 0xe8) * 4))
		                    (uVar1,uVar3,uVar6,*(undefined4 *)(iVar16 + 0xec));
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  piVar11 = (int *)func_ii_5677(uVar7,Method_UnityEngine_Component_GetComponent_IconValueRender___);
		  uVar1 = CONCAT44(uVar6,param1);
		  uVar3 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0xf4));
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(uVar1,uVar3);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar7 = func_ii_8038(uVar7,0);
		  if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		  }
		  Utils_ResourceRewardsUtils__GetRewardTypes(&local_10,uVar7,0);
		  local_8 = local_10;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar12 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar8 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0x178);
		        goto code_r0x810b0bb0;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar8 = (uint *)func_ii_1080(piVar12,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810b0bb0:
		  uVar1 = CONCAT44(uVar2,piVar12);
		  uVar3 = CONCAT44(uVar6,puVar8[1]);
		  uVar7 = (**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar3);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  param2_00 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                        (&local_8,Method_System_Nullable_Resources__get_Value__);
		  iVar13 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar7,param2_00,0);
		  if (iVar13 != 0) {
		    uVar7 = func_ii_7611(iVar13,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(piVar11[10],uVar7,0);
		  }
		  uVar1 = CONCAT44(uVar6,param1);
		  uVar3 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0xf4));
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(uVar1,uVar3);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  piVar12 = (int *)func_ii_7225(uVar7,0);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar14 = 0;
		    do {
		      if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar8 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x810b0c87;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar8 = (uint *)func_ii_1080(piVar12,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b0c87:
		  uVar1 = CONCAT44(uVar6,piVar12);
		  uVar3 = CONCAT44(uVar2,puVar8[1]);
		  piVar12 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar3);
		  uVar5 = (uint)((ulonglong)uVar3 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar14 = 0;
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_long__TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8)) {
		        puVar8 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x810b0d07;
		      }
		      uVar14 = uVar14 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar14);
		  }
		  puVar8 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		code_r0x810b0d07:
		  uVar1 = CONCAT44(uVar6,piVar12);
		  lVar4 = (ulonglong)uVar5 << 0x20;
		  lVar9 = (**(code **)((ulonglong)*puVar8 * 4))(uVar1,lVar4,puVar8[1]);
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),param1);
		  uVar3 = CONCAT44((int)((ulonglong)lVar4 >> 0x20),*(undefined4 *)(*param1 + 0xf4));
		  uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(uVar1,uVar3);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar6 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  iVar13 = func_ii_8038(uVar7,0);
		  if (iVar13 == 1) {
		    uVar1 = CONCAT44(uVar2,param1);
		    uVar3 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0xf4));
		    uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(uVar1,uVar3);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    piVar12 = (int *)func_ii_7225(uVar7,0);
		    iVar16 = *piVar12;
		    if (*(ushort *)(iVar16 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		            *(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8)) {
		          puVar8 = (uint *)(*(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8 + 4) * 8 + iVar16 + 0xd0);
		          goto code_r0x810b0edb;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar16 + 0xb6) != uVar14);
		    }
		    puVar8 = (uint *)func_ii_1080(piVar12,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b0edb:
		    uVar1 = CONCAT44(uVar6,piVar12);
		    uVar3 = CONCAT44(uVar2,puVar8[1]);
		    piVar12 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar3);
		    uVar5 = (uint)((ulonglong)uVar3 >> 0x20);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar14 = 0;
		    iVar16 = *piVar12;
		    if (*(ushort *)(iVar16 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_long__TypeInfo ==
		            *(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8)) {
		          puVar8 = (uint *)(iVar16 + *(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x810b0f55;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar16 + 0xb6) != uVar14);
		    }
		    puVar8 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		  }
		  else {
		    if (iVar13 != 2) goto code_r0x810b0f98;
		    uVar1 = CONCAT44(uVar2,param1);
		    uVar3 = CONCAT44(uVar6,*(undefined4 *)(*param1 + 0xf4));
		    uVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(uVar1,uVar3);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar2 = (undefined4)((ulonglong)uVar3 >> 0x20);
		    piVar12 = (int *)func_ii_7225(uVar7,0);
		    iVar16 = *piVar12;
		    if (*(ushort *)(iVar16 + 0xb6) != 0) {
		      uVar14 = 0;
		      do {
		        if (Core_Data_Decorators_IRewardInfo_TypeInfo ==
		            *(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8)) {
		          puVar8 = (uint *)(*(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8 + 4) * 8 + iVar16 + 0xd0);
		          goto code_r0x810b0dd2;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar16 + 0xb6) != uVar14);
		    }
		    puVar8 = (uint *)func_ii_1080(piVar12,Core_Data_Decorators_IRewardInfo_TypeInfo,2);
		code_r0x810b0dd2:
		    uVar1 = CONCAT44(uVar6,piVar12);
		    uVar3 = CONCAT44(uVar2,puVar8[1]);
		    piVar12 = (int *)(**(code **)((ulonglong)*puVar8 * 4))(uVar1,uVar3);
		    uVar5 = (uint)((ulonglong)uVar3 >> 0x20);
		    uVar6 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar14 = 0;
		    iVar16 = *piVar12;
		    if (*(ushort *)(iVar16 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_IList_long__TypeInfo ==
		            *(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8)) {
		          puVar8 = (uint *)(iVar16 + *(int *)(*(int *)(iVar16 + 0x58) + uVar14 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x810b0f55;
		        }
		        uVar14 = uVar14 + 1;
		      } while (*(ushort *)(iVar16 + 0xb6) != uVar14);
		    }
		    puVar8 = (uint *)func_ii_1080(piVar12,System_Collections_Generic_IList_long__TypeInfo,0);
		  }
		code_r0x810b0f55:
		  lVar9 = (**(code **)((ulonglong)*puVar8 * 4))
		                    (CONCAT44(uVar6,piVar12),(ulonglong)uVar5 << 0x20,puVar8[1]);
		  dVar15 = (double)lVar9;
		  dVar10 = Utils_LongTap__DetectStartLongTapCoroutine_d__41__System_Collections_IEnumerator_get_Current
		                     (iVar13,dVar15,0,0);
		  uVar6 = (undefined4)((ulonglong)dVar15 >> 0x20);
		  if (ABS(dVar10) < 9.223372036854776e+18) {
		    lVar9 = (longlong)dVar10;
		  }
		  else {
		    lVar9 = -0x8000000000000000;
		  }
		code_r0x810b0f98:
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  dVar15 = (double)lVar9;
		  iVar13 = UI_SimpleIconValue__set_IconAssetId(dVar15,StringLiteral_28780,0);
		  uVar2 = (undefined4)((ulonglong)dVar15 >> 0x20);
		  iVar16 = System_Collections_CollectionBase___ctor(piVar11[0xc],iVar13,0);
		  if (iVar16 == 0) {
		    piVar11[0xc] = iVar13;
		    (**(code **)((ulonglong)*(uint *)(*piVar11 + 0x110) * 4))
		              (CONCAT44(uVar2,piVar11),CONCAT44(uVar6,*(undefined4 *)(*piVar11 + 0x114)));
		  }
		  return;
		}
		*/

		}
	}
}
