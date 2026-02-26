using System;
using AssetContent.Loaders;
using Core.Animations;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.ProgressBars;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000958 RID: 2392
	[Token(Token = "0x2000958")]
	public class PetViewV2 : AbstractPetView
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x8855", Offset = "0x8855", VA = "0x8855", Slot = "14")]
		protected override void HandleIsDeadChanged()
		{
		/* --- GHIDRA: HandleIsDeadChanged ---
		void Gameplay_Combat_View_Players_Pet_PetViewV2__HandleIsDeadChanged(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 0x14),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x8856", Offset = "0x8856", VA = "0x8856", Slot = "13")]
		protected override void HandleVisibleChanged()
		{
		/* --- GHIDRA: HandleVisibleChanged ---
		void Gameplay_Combat_View_Players_Pet_PetViewV2__HandleVisibleChanged(int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a56712 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a56712 = '\x01';
		  }
		  if (param1[6] != 0) {
		    param2_00 = Core_Extensions_Dict_ArtikulDicExt__GetIconAssetId
		                          (*(undefined4 *)(*(int *)(*(int *)(param1[6] + 8) + 8) + 0x10),0);
		    AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(param1[8],param2_00,0);
		    *(undefined1 *)(param1 + 7) = 0;
		    if (DAT_ram_00a5670e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Gameplay_Combat_View_Players_Pet_AbstractPetView__UpdateHealth_b__16_0__);
		      Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		      Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tween___);
		      DAT_ram_00a5670e = '\x01';
		    }
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		              (param1,param1[6],param1[4],*(undefined4 *)(*param1 + 0x13c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B9")]
		[Address(RVA = "0x8857", Offset = "0x8857", VA = "0x8857", Slot = "12")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Combat_View_Players_Pet_PetViewV2__HandleDataChanged
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  longlong lVar5;
		  int iVar6;
		  int *piVar7;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a56713 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a56713 = '\x01';
		  }
		  lVar5 = Gameplay_Combat_Model_PetData___ctor(param2,0);
		  local_8 = lVar5;
		  local_10 = Gameplay_Combat_Model_PetData__get_CurrentHeal(param2,0);
		  fVar1 = UnityEngine_Camera__set_orthographicSize((float)lVar5,(float)local_10,0);
		  iVar6 = *(int *)(param1[9] + 0x18);
		  uVar2 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(param3,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar4 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar4 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar4,StringLiteral_1618,param3_00,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_18;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar3,0);
		  lVar5 = local_8;
		  *(undefined4 *)(iVar6 + 0x28) = uVar2;
		  piVar7 = (int *)param1[9];
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = func_ii_8614((double)lVar5,0,0);
		  iVar3 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x118) * 4))
		            (piVar7,uVar2,*(undefined4 *)(iVar3 + 0x11c));
		  iVar3 = *(int *)param1[9];
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x108) * 4))
		            ((int *)param1[9],fVar1,*(undefined4 *)(iVar3 + 0x10c));
		  if (local_8 < 1 != (bool)(char)param1[7]) {
		    *(bool *)(param1 + 7) = local_8 < 1;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x134));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038BA RID: 14522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BA")]
		[Address(RVA = "0x8858", Offset = "0x8858", VA = "0x8858", Slot = "15")]
		protected override void DisplayCurrentHealth(PetData petData, UserSkillDic userSkillDic)
		{
		/* --- GHIDRA: DisplayCurrentHealth ---
		void Gameplay_Combat_View_Players_Pet_PetViewV2__DisplayCurrentHealth(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x14) = 1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x8859", Offset = "0x8859", VA = "0x8859")]
		public PetViewV2()
		{
		}

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameSpriteRendererLoader _image;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBarLiquidWithEdge _healBar;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSpineUiAnimation _deathAnimation;
	}
}
