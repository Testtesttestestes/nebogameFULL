using System;
using AssetContent.Loaders;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000957 RID: 2391
	[Token(Token = "0x2000957")]
	public class PetView : AbstractPetView
	{
		// Token: 0x060038B2 RID: 14514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x8850", Offset = "0x8850", VA = "0x8850", Slot = "14")]
		protected override void HandleIsDeadChanged()
		{
		/* --- GHIDRA: HandleIsDeadChanged ---
		void Gameplay_Combat_View_Players_Pet_PetView__HandleIsDeadChanged(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
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

		// Token: 0x060038B3 RID: 14515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x8851", Offset = "0x8851", VA = "0x8851", Slot = "13")]
		protected override void HandleVisibleChanged()
		{
		/* --- GHIDRA: HandleVisibleChanged ---
		void Gameplay_Combat_View_Players_Pet_PetView__HandleVisibleChanged(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a56710 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a56710 = '\x01';
		  }
		  if (param1[6] != 0) {
		    uVar1 = Core_Extensions_Dict_AprMarkerDicExt__GetTitle
		                      (*(undefined4 *)(*(int *)(*(int *)(param1[6] + 8) + 8) + 0x10),0);
		    AssetContent_Loaders_GameSpriteRendererLoader__get_AssetId(param1[9],uVar1,0);
		    piVar2 = (int *)param1[8];
		    uVar1 = Gameplay_Combat_Model_PetData__set_Artifact(param1[6],0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
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

		// Token: 0x060038B4 RID: 14516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x8852", Offset = "0x8852", VA = "0x8852", Slot = "12")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Combat_View_Players_Pet_PetView__HandleDataChanged
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
		  
		  if (DAT_ram_00a56711 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a56711 = '\x01';
		  }
		  lVar5 = Gameplay_Combat_Model_PetData___ctor(param2,0);
		  local_8 = lVar5;
		  local_10 = Gameplay_Combat_Model_PetData__get_CurrentHeal(param2,0);
		  fVar1 = UnityEngine_Camera__set_orthographicSize((float)lVar5,(float)local_10,0);
		  iVar6 = *(int *)(param1[10] + 0x18);
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
		  piVar7 = (int *)param1[10];
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar2 = func_ii_8614((double)lVar5,0,0);
		  iVar3 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x118) * 4))
		            (piVar7,uVar2,*(undefined4 *)(iVar3 + 0x11c));
		  iVar3 = *(int *)param1[10];
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x108) * 4))
		            ((int *)param1[10],fVar1,*(undefined4 *)(iVar3 + 0x10c));
		  if (local_8 < 1 != (bool)(char)param1[7]) {
		    *(bool *)(param1 + 7) = local_8 < 1;
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		              (param1,*(undefined4 *)(*param1 + 0x134));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x8853", Offset = "0x8853", VA = "0x8853", Slot = "15")]
		protected override void DisplayCurrentHealth(PetData petData, UserSkillDic userSkillDic)
		{
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x8854", Offset = "0x8854", VA = "0x8854")]
		public PetView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_Pet_PetView___ctor(int param1,undefined4 param2)
		
		{
		  float param2_00;
		  
		  if (*(char *)(param1 + 0x1c) == '\0') {
		    param2_00 = 0.0;
		  }
		  else {
		    func_ii_7357(*(undefined4 *)(param1 + 0x28),0,0);
		    param2_00 = 1.0;
		    if (*(char *)(param1 + 0x1c) == '\0') {
		      param2_00 = 0.0;
		    }
		  }
		  AssetContent_Loaders_GameSpriteRendererLoader__HandleSpriteChanged
		            (*(undefined4 *)(param1 + 0x20),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04001F4F RID: 8015
		[Token(Token = "0x4001F4F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameSpriteRendererLoader _image;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CombatProgressBar _healBar;
	}
}
