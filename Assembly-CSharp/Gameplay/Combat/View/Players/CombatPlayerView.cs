using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players.LongEffects;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000949 RID: 2377
	[Token(Token = "0x2000949")]
	public class CombatPlayerView : MonoBehaviour, ICombatPLayerView
	{
		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B15")]
		public SkillsInfo SkillsInfo
		{
			[Token(Token = "0x600383A")]
			[Address(RVA = "0x87F1", Offset = "0x87F1", VA = "0x87F1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B16")]
		public LevelView Level
		{
			[Token(Token = "0x600383B")]
			[Address(RVA = "0x87F2", Offset = "0x87F2", VA = "0x87F2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B17")]
		public RankView Rank
		{
			[Token(Token = "0x600383C")]
			[Address(RVA = "0x87F3", Offset = "0x87F3", VA = "0x87F3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600383E RID: 14398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B18")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x600383D")]
			[Address(RVA = "0x87F4", Offset = "0x87F4", VA = "0x87F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600383E")]
			[Address(RVA = "0x87F5", Offset = "0x87F5", VA = "0x87F5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003840 RID: 14400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B19")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x600383F")]
			[Address(RVA = "0x87F6", Offset = "0x87F6", VA = "0x87F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003840")]
			[Address(RVA = "0x87F7", Offset = "0x87F7", VA = "0x87F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003842 RID: 14402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1A")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6003841")]
			[Address(RVA = "0x87F8", Offset = "0x87F8", VA = "0x87F8", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003842")]
			[Address(RVA = "0x87F9", Offset = "0x87F9", VA = "0x87F9", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x87FA", Offset = "0x87FA", VA = "0x87FA")]
		private void HandlePlayerChanged()
		{
		/* --- GHIDRA: HandlePlayerChanged ---
		void Gameplay_Combat_View_Players_CombatPlayerView__HandlePlayerChanged
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  float fVar7;
		  int iVar8;
		  int *piVar9;
		  double dVar10;
		  double param2_00;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  lVar2 = param2;
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a566f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a566f6 = '\x01';
		  }
		  fVar7 = 0.0;
		  if (param3 != 0) {
		    fVar7 = (float)param2 / (float)param3;
		  }
		  iVar8 = *(int *)(*(int *)(param1 + 0x34) + 0x18);
		  uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		  uVar4 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(*(undefined4 *)(param1 + 0x44),0);
		  iVar5 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar6 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar6 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar6,StringLiteral_1618,param3_00,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar6,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar5 + 0x10) = local_18;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar5,0);
		  lVar1 = local_8;
		  lVar2 = local_10;
		  *(undefined4 *)(iVar8 + 0x28) = uVar4;
		  piVar9 = *(int **)(param1 + 0x34);
		  if (*(int *)(param1 + 0x3c) == 1) {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar10 = (double)lVar1;
		    iVar5 = UI_SimpleIconValue__set_IconAssetId(dVar10,StringLiteral_28780,0);
		    uVar4 = (undefined4)((ulonglong)dVar10 >> 0x20);
		    if (iVar5 == 0) {
		      iVar5 = StringLiteral_5;
		    }
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar10 = (double)lVar1;
		    param2_00 = (double)lVar2;
		    iVar5 = Utils_StringUtils__GetRomanNumber(dVar10,param2_00,0);
		    uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    uVar4 = (undefined4)((ulonglong)dVar10 >> 0x20);
		  }
		  iVar8 = *piVar9;
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x118) * 4))
		            (CONCAT44(uVar4,piVar9),CONCAT44(uVar3,iVar5),*(undefined4 *)(iVar8 + 0x11c));
		  iVar5 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x108) * 4))
		            (*(int **)(param1 + 0x34),fVar7,*(undefined4 *)(iVar5 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06003844 RID: 14404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003844")]
		[Address(RVA = "0x87FB", Offset = "0x87FB", VA = "0x87FB")]
		private void SetHealth(long current, long total)
		{
		/* --- GHIDRA: SetHealth ---
		void Gameplay_Combat_View_Players_CombatPlayerView__SetHealth
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 param3_00;
		  float fVar7;
		  int iVar8;
		  int *piVar9;
		  double dVar10;
		  double param2_00;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  lVar2 = param2;
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a566f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a566f7 = '\x01';
		  }
		  fVar7 = 0.0;
		  if (param3 != 0) {
		    fVar7 = (float)param2 / (float)param3;
		  }
		  iVar8 = *(int *)(*(int *)(param1 + 0x38) + 0x18);
		  uVar3 = (undefined4)((ulonglong)lVar2 >> 0x20);
		  uVar4 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(*(undefined4 *)(param1 + 0x48),0);
		  iVar5 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  uVar6 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar6 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar6,StringLiteral_1618,param3_00,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28217,uVar6,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar5 + 0x10) = local_18;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar5,0);
		  lVar1 = local_8;
		  lVar2 = local_10;
		  *(undefined4 *)(iVar8 + 0x28) = uVar4;
		  piVar9 = *(int **)(param1 + 0x38);
		  if (*(int *)(param1 + 0x3c) == 1) {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar10 = (double)lVar1;
		    uVar6 = UI_SimpleIconValue__set_IconAssetId(dVar10,StringLiteral_28780,0);
		    uVar4 = (undefined4)((ulonglong)dVar10 >> 0x20);
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    dVar10 = (double)lVar1;
		    param2_00 = (double)lVar2;
		    uVar6 = Utils_StringUtils__GetRomanNumber(dVar10,param2_00,0);
		    uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    uVar4 = (undefined4)((ulonglong)dVar10 >> 0x20);
		  }
		  iVar5 = *piVar9;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x118) * 4))
		            (CONCAT44(uVar4,piVar9),CONCAT44(uVar3,uVar6),*(undefined4 *)(iVar5 + 0x11c));
		  iVar5 = **(int **)(param1 + 0x38);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x108) * 4))
		            (*(int **)(param1 + 0x38),fVar7,*(undefined4 *)(iVar5 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003845")]
		[Address(RVA = "0x87FC", Offset = "0x87FC", VA = "0x87FC")]
		private void SetMana(long current, long total)
		{
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1B")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6003846")]
			[Address(RVA = "0x87FD", Offset = "0x87FD", VA = "0x87FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003847")]
			[Address(RVA = "0x87FE", Offset = "0x87FE", VA = "0x87FE")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003848")]
		[Address(RVA = "0x87FF", Offset = "0x87FF", VA = "0x87FF")]
		private void ResetPoolObjectDelegate(LongEffect pooledobject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void Gameplay_Combat_View_Players_CombatPlayerView__ResetPoolObjectDelegate
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a566f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_LongEffect__Clear__);
		    DAT_ram_00a566f8 = '\x01';
		  }
		  if (*(int *)(param1 + 0x54) != 0) {
		    Utils_Cache_ObjectPool_object____ctor
		              (*(int *)(param1 + 0x54),Method_Utils_Cache_ObjectPool_LongEffect__Clear__);
		  }
		  iVar1 = *(int *)(param1 + 0x50);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined4 *)(*(int *)(param1 + 0x30) + 0x2c) = 0;
		  *(undefined4 *)(param1 + 0x58) = 0;
		  *(undefined8 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003849")]
		[Address(RVA = "0x8800", Offset = "0x8800", VA = "0x8800")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		int Gameplay_Combat_View_Players_CombatPlayerView__OnDestroy
		              (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  *(undefined4 *)(*(int *)(param1 + 0x30) + 0x28) = param4;
		  *(undefined4 *)(param1 + 0x58) = param3;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,4,0);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,5,0);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  *(undefined4 *)(*(int *)(param1 + 0x2c) + 0x10) = *(undefined4 *)(param1 + 0x44);
		  if (param2 != *(int *)(param1 + 0x4c)) {
		    *(int *)(param1 + 0x4c) = param2;
		    Gameplay_Combat_View_Players_CombatPlayerView__set_Player(param1,param1);
		  }
		  *(undefined1 *)(param1 + 0x5c) = 1;
		  return param1;
		}
		*/

		}

		// Token: 0x0600384A RID: 14410 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x8801", Offset = "0x8801", VA = "0x8801", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Combat_View_Players_CombatPlayerView__Init(int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x4c),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Combat_View_Players_CombatPlayerView__HandlePlayerChanged(param1,param2_00,param3,param1)
		  ;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x8802", Offset = "0x8802", VA = "0x8802")]
		public void UpdateHealth()
		{
		/* --- GHIDRA: UpdateHealth ---
		void Gameplay_Combat_View_Players_CombatPlayerView__UpdateHealth(int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x4c),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Combat_View_Players_CombatPlayerView__SetHealth(param1,param2_00,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x8803", Offset = "0x8803", VA = "0x8803")]
		public void UpdateMana()
		{
		/* --- GHIDRA: UpdateMana ---
		void Gameplay_Combat_View_Players_CombatPlayerView__UpdateMana
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  
		  if (param2 == 3) {
		    uVar1 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x4c),0);
		    uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x4c),0);
		    Gameplay_Combat_View_Players_CombatPlayerView__HandlePlayerChanged(param1,uVar1,uVar2,param1);
		    return;
		  }
		  if (param2 == 4) {
		    uVar1 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x4c),0);
		    uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x4c),0);
		    Gameplay_Combat_View_Players_CombatPlayerView__SetHealth(param1,uVar1,uVar2,param1);
		    return;
		  }
		  Gameplay_Combat_View_Players_SkillsInfo__OnEnable(*(undefined4 *)(param1 + 0x30),param1);
		  return;
		}
		*/

		}

		// Token: 0x0600384D RID: 14413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384D")]
		[Address(RVA = "0x8804", Offset = "0x8804", VA = "0x8804", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		/* --- GHIDRA: UpdateUserSkill ---
		void Gameplay_Combat_View_Players_CombatPlayerView__UpdateUserSkill(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param3;
		  
		  param3 = *(int *)(param1 + 0x30);
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param3 + 0x1c),0);
		  if (iVar1 != 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param3 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(*(int *)(*(int *)(*(int *)(param3 + 0x2c) + 0x14) + 0x78) != 0),0);
		    Gameplay_Combat_View_Players_CombatUserBalance__Start
		              (*(undefined4 *)(param3 + 0x1c),
		               *(undefined4 *)(*(int *)(*(int *)(param3 + 0x2c) + 0x14) + 0x78),param3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600384E RID: 14414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600384E")]
		[Address(RVA = "0x8805", Offset = "0x8805", VA = "0x8805", Slot = "6")]
		public void UpdateBalance()
		{
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x600384F")]
		[Address(RVA = "0x8806", Offset = "0x8806", VA = "0x8806", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
		/* --- GHIDRA: TryGetLevel ---
		undefined4
		Gameplay_Combat_View_Players_CombatPlayerView__TryGetLevel
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  *param2 = *(undefined4 *)(param1 + 0x2c);
		  uVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x6003850")]
		[Address(RVA = "0x8807", Offset = "0x8807", VA = "0x8807", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x0000B400 File Offset: 0x00009600
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1C")]
		public bool IsInit
		{
			[Token(Token = "0x6003851")]
			[Address(RVA = "0x8808", Offset = "0x8808", VA = "0x8808", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003852")]
			[Address(RVA = "0x8809", Offset = "0x8809", VA = "0x8809")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x0000B418 File Offset: 0x00009618
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B1D")]
		public bool Select
		{
			[Token(Token = "0x6003853")]
			[Address(RVA = "0x880A", Offset = "0x880A", VA = "0x880A", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x880B", Offset = "0x880B", VA = "0x880B", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003855")]
		[Address(RVA = "0x880C", Offset = "0x880C", VA = "0x880C", Slot = "7")]
		public void UpdateLongEffects()
		{
		/* --- GHIDRA: UpdateLongEffects ---
		void Gameplay_Combat_View_Players_CombatPlayerView__UpdateLongEffects
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  AssetContent_GameAssetViewSpriteRenderer__get_Bounds
		            (*(undefined4 *)(param1 + 0x10),param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003856 RID: 14422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003856")]
		[Address(RVA = "0x880D", Offset = "0x880D", VA = "0x880D", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		/* --- GHIDRA: ShowDeathState ---
		void Gameplay_Combat_View_Players_CombatPlayerView__ShowDeathState(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566fa == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LongEffect__TypeInfo);
		    DAT_ram_00a566fa = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_GameObject___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_LongEffect__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,10,Method_System_Collections_Generic_List_LongEffect___ctor__);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003857")]
		[Address(RVA = "0x880E", Offset = "0x880E", VA = "0x880E")]
		public CombatPlayerView()
		{
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003858")]
		[Address(RVA = "0x880F", Offset = "0x880F", VA = "0x880F", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04001F19 RID: 7961
		[Token(Token = "0x4001F19")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _avatar;

		// Token: 0x04001F1A RID: 7962
		[Token(Token = "0x4001F1A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04001F1B RID: 7963
		[Token(Token = "0x4001F1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LevelView _level;

		// Token: 0x04001F1C RID: 7964
		[Token(Token = "0x4001F1C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RankView _rank;

		// Token: 0x04001F1D RID: 7965
		[Token(Token = "0x4001F1D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private NickBarCultFiller _cultFiller;

		// Token: 0x04001F1E RID: 7966
		[Token(Token = "0x4001F1E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LongEffectsView _longEffectsView;

		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LongEffect _longEffectPrefab;

		// Token: 0x04001F20 RID: 7968
		[Token(Token = "0x4001F20")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private PetViewV2 _pet;

		// Token: 0x04001F21 RID: 7969
		[Token(Token = "0x4001F21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SkillsInfo _skillsInfo;

		// Token: 0x04001F22 RID: 7970
		[Token(Token = "0x4001F22")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ProgressBarWithText _healBar;

		// Token: 0x04001F23 RID: 7971
		[Token(Token = "0x4001F23")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ProgressBarWithText _manaBar;

		// Token: 0x04001F24 RID: 7972
		[Token(Token = "0x4001F24")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CombatPlayerView.SkillPbTextFormat _skillPbTextFormat;

		// Token: 0x04001F25 RID: 7973
		[Token(Token = "0x4001F25")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject[] _gameObjectsForActivate;

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		[FieldOffset(Offset = "0x4C")]
		private CombatPlayer _player;

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<LongEffect> _currentLongEffects;

		// Token: 0x04001F2A RID: 7978
		[Token(Token = "0x4001F2A")]
		[FieldOffset(Offset = "0x54")]
		private GameObjectPool<LongEffect> _longEffectPool;

		// Token: 0x0200094A RID: 2378
		[Token(Token = "0x200094A")]
		public enum SkillPbTextFormat
		{
			// Token: 0x04001F2F RID: 7983
			[Token(Token = "0x4001F2F")]
			Default,
			// Token: 0x04001F30 RID: 7984
			[Token(Token = "0x4001F30")]
			Shortly
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Player ---
		void Gameplay_Combat_View_Players_CombatPlayerView__get_Player
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x4c)) {
		    *(int *)(param1 + 0x4c) = param2;
		    Gameplay_Combat_View_Players_CombatPlayerView__set_Player(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Player ---
		void Gameplay_Combat_View_Players_CombatPlayerView__set_Player(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 in_i2q;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined8 uVar4;
		  undefined8 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 uVar10;
		  int iVar11;
		  
		  uVar2 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  if (DAT_ram_00a566f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo);
		    DAT_ram_00a566f5 = '\x01';
		  }
		  iVar9 = *(int *)(param1 + 0x4c);
		  *(int *)(*(int *)(param1 + 0x30) + 0x2c) = iVar9;
		  iVar11 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar11 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x14),
		             CONCAT44(in_register_20000014,
		                      *(undefined4 *)(*(int *)(*(int *)(iVar9 + 8) + 0xc) + 0x18)),
		             CONCAT44(uVar2,*(undefined4 *)(iVar11 + 0x2d4)));
		  piVar6 = *(int **)(param1 + 0x20);
		  piVar6[7] = *(int *)(*(int *)(param1 + 0x4c) + 0x20);
		  (**(code **)((ulonglong)*(uint *)(*piVar6 + 0xe0) * 4))(piVar6,*(undefined4 *)(*piVar6 + 0xe4));
		  uVar7 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__set_User(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_UserInterface_View_LevelView__set_IsPremiumExp(uVar7,uVar2,0);
		  uVar7 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__get_Level(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_UserInterface_View_LocationOwnerIndexView___ctor(uVar7,uVar2,0);
		  uVar4 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x4c),0);
		  uVar5 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Combat_View_Players_CombatPlayerView__SetHealth(param1,uVar4,uVar5,piVar6);
		  uVar4 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x4c),0);
		  uVar5 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Combat_View_Players_CombatPlayerView__HandlePlayerChanged(param1,uVar4,uVar5,piVar6);
		  uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar9 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x10),0);
		  if (iVar9 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar6;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		          goto code_r0x80c6a8bc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80c6a8bc:
		    uVar4 = CONCAT44(uVar2,puVar3[1]);
		    uVar10 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar10 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar10,0);
		    uVar10 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                       (uVar10,*(undefined4 *)
		                                (*(int *)(*(int *)(*(int *)(param1 + 0x4c) + 8) + 0xc) + 0x1c),0);
		    uVar10 = Core_Extensions_Dict_AprDicExt__Get256AssetId(uVar10,0);
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(*(undefined4 *)(param1 + 0x10),uVar10,0);
		  }
		  iVar9 = 0;
		  piVar6 = *(int **)(param1 + 0x2c);
		  iVar11 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(piVar6,0);
		  if (iVar11 != 0) {
		    uVar1 = 0;
		    iVar11 = *(int *)(*(int *)(param1 + 0x4c) + 0x1c);
		    iVar8 = *piVar6;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd8);
		          goto code_r0x80c6a987;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo,3);
		code_r0x80c6a987:
		    uVar1 = 0;
		    uVar4 = CONCAT44(uVar2,(uint)(iVar11 != 0));
		    uVar5 = CONCAT44(uVar7,puVar3[1]);
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar4,uVar5);
		    uVar7 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar10 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x1c);
		    iVar11 = *piVar6;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo ==
		            *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xe8);
		          goto code_r0x80c6aa14;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo,5);
		code_r0x80c6aa14:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,CONCAT44(uVar2,uVar10),CONCAT44(uVar7,puVar3[1]));
		  }
		  iVar11 = *(int *)(param1 + 0x40);
		  if (0 < *(int *)(iVar11 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar11 + iVar9 * 4 + 0x10),(uint)(*(int *)(param1 + 0x4c) != 0),0);
		      iVar9 = iVar9 + 1;
		    } while (iVar9 < *(int *)(iVar11 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Select ---
		void Gameplay_Combat_View_Players_CombatPlayerView__set_Select(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  undefined4 param3;
		  int iVar5;
		  int iVar6;
		  int param1_01;
		  uint uVar7;
		  int *param1_02;
		  
		  if (DAT_ram_00a566f9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Players_CombatPlayerView_ResetPoolObjectDelegate__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPool_LongEffect___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_LongEffect__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Sound_Control_IGameAudio_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_LongEffect__Get__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_LongEffect__Release__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_LongEffect__TypeInfo);
		    DAT_ram_00a566f9 = '\x01';
		  }
		  if (*(int *)(param1 + 0x54) == 0) {
		    param2_00 = *(undefined4 *)(param1 + 0x28);
		    param3 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0x1c);
		    uVar4 = unnamed_function_1417
		                      (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_LongEffect__TypeInfo);
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (uVar4,param1,
		               Method_Gameplay_Combat_View_Players_CombatPlayerView_ResetPoolObjectDelegate__,0);
		    param1_00 = unnamed_function_1417(Utils_Cache_GameObjectPool_LongEffect__TypeInfo);
		    Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		              (param1_00,param2_00,param3,uVar4,
		               Method_Utils_Cache_GameObjectPool_LongEffect___ctor__);
		    *(undefined4 *)(param1 + 0x54) = param1_00;
		  }
		  iVar1 = 0;
		  iVar5 = *(int *)(param1 + 0x50);
		  iVar6 = *(int *)(iVar5 + 0xc);
		  if (iVar6 < 1) {
		    *(undefined4 *)(iVar5 + 0xc) = 0;
		    *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  }
		  else {
		    do {
		      uVar4 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x50),iVar1,
		                         Method_System_Collections_Generic_List_LongEffect__get_Item__);
		      func_ii_7070(*(undefined4 *)(param1 + 0x54),uVar4,
		                   Method_Utils_Cache_ObjectPool_LongEffect__Release__);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar6);
		    iVar1 = *(int *)(param1 + 0x50);
		    iVar5 = *(int *)(iVar1 + 0xc);
		    *(undefined4 *)(iVar1 + 0xc) = 0;
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    if (0 < iVar5) {
		      func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar5,0);
		    }
		  }
		  iVar1 = *(int *)(*(int *)(*(int *)(param1 + 0x4c) + 0x24) + 0xc);
		  if (0 < iVar1) {
		    iVar5 = 0;
		    do {
		      iVar6 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x24),iVar5,
		                         Method_System_Collections_Generic_List_EffectData__get_Item__);
		      iVar2 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                        (*(undefined4 *)(param1 + 0x54),
		                         Method_Utils_Cache_ObjectPool_LongEffect__Get__);
		      if (iVar6 != *(int *)(iVar2 + 0x34)) {
		        *(int *)(iVar2 + 0x34) = iVar6;
		        Gameplay_Combat_View_Players_LongEffects_LongEffect__set_Data(iVar2,param1);
		      }
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (iVar2,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      iVar6 = Method_System_Collections_Generic_List_LongEffect__Add__;
		      param1_01 = *(int *)(param1 + 0x50);
		      *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		      uVar7 = *(uint *)(param1_01 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		        *(uint *)(param1_01 + 0xc) = uVar7 + 1;
		        *(int *)(*(int *)(param1_01 + 8) + uVar7 * 4 + 0x10) = iVar2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar1);
		    if (0 < *(int *)(*(int *)(*(int *)(param1 + 0x4c) + 0x24) + 0xc)) {
		      uVar7 = 0;
		      param1_02 = *(int **)(param1 + 0x58);
		      iVar1 = *param1_02;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		              *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 200);
		            goto code_r0x80c6c064;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_02,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80c6c064:
		      (**(code **)((ulonglong)*puVar3 * 4))(param1_02,0xe,puVar3[1]);
		    }
		  }
		  iVar1 = *(int *)(param1 + 0x24);
		  iVar6 = *(int *)(*(int *)(param1 + 0x50) + 0xc);
		  *(int *)(iVar1 + 0x2c) = iVar6;
		  iVar5 = *(int *)(iVar1 + 0x10);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    iVar2 = 0;
		    if (iVar6 < 1) {
		      do {
		        uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar5 + iVar2 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar4,0,0);
		        iVar2 = iVar2 + 1;
		      } while (iVar2 < *(int *)(iVar5 + 0xc));
		    }
		    else {
		      do {
		        uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar5 + iVar2 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar4,(uint)(*(int *)(iVar1 + 0x24) < iVar6),0);
		        iVar2 = iVar2 + 1;
		      } while (iVar2 < *(int *)(iVar5 + 0xc));
		    }
		  }
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(0 < *(int *)(*(int *)(param1 + 0x50) + 0xc)),0);
		  return;
		}
		*/


		/* --- GHIDRA: Gameplay.Combat.View.Players.ICombatPLayerView.get_gameObject ---
		void Gameplay_Combat_View_Players_CombatPlayerView__Gameplay_Combat_View_Players_ICombatPLayerView_get_gameObject
		               (int *param1,undefined8 param2,double param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int *piVar3;
		  int iVar4;
		  float8 local_10;
		  undefined8 local_8;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0xe4));
		  uVar1 = (undefined4)((ulonglong)param2 >> 0x20);
		  if ((ulonglong)ABS(param3) < 0x7ff0000000000001) {
		    if (DAT_ram_00a566fb == '\0') {
		      Mono_Security_ASN1__get_Item(&StringLiteral_28648);
		      DAT_ram_00a566fb = '\x01';
		    }
		    piVar3 = (int *)param1[8];
		    local_8 = *(undefined8 *)(param1 + 0xc);
		    uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		    local_10 = (float8)param3;
		    param3_00 = func_ii_1081(DAT_ram_00a66970,&local_10);
		    uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28648,uVar2,param3_00,0);
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar3,CONCAT44(uVar1,uVar2),*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  return;
		}
		*/

}
