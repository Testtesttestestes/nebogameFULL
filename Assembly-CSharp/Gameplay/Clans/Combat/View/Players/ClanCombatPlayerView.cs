using System;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Aprs.View;
using Gameplay.Clans.Combat.Model;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Clans.Combat.View.Players
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	public class ClanCombatPlayerView : MonoBehaviour, ICombatPLayerView, IToolTipDataProvider
	{
		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06004127 RID: 16679 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004128 RID: 16680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD8")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x6004127")]
			[Address(RVA = "0x8FDE", Offset = "0x8FDE", VA = "0x8FDE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004128")]
			[Address(RVA = "0x8FDF", Offset = "0x8FDF", VA = "0x8FDF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600412A RID: 16682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD9")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x6004129")]
			[Address(RVA = "0x8FE0", Offset = "0x8FE0", VA = "0x8FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600412A")]
			[Address(RVA = "0x8FE1", Offset = "0x8FE1", VA = "0x8FE1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600412B")]
		[Address(RVA = "0x8FE2", Offset = "0x8FE2", VA = "0x8FE2", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__Init
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int iVar5;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a5777e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a5777e = '\x01';
		  }
		  fVar1 = UnityEngine_Camera__set_orthographicSize((float)param2,(float)param3,0);
		  iVar5 = *(int *)(*(int *)(param1 + 0x24) + 0x18);
		  uVar2 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(*(undefined4 *)(param1 + 0x2c),0);
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
		  *(undefined4 *)(iVar5 + 0x28) = uVar2;
		  iVar3 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x108) * 4))
		            (*(int **)(param1 + 0x24),fVar1,*(undefined4 *)(iVar3 + 0x10c));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412C")]
		[Address(RVA = "0x8FE3", Offset = "0x8FE3", VA = "0x8FE3")]
		private void SetHealth(long current, long total)
		{
		/* --- GHIDRA: SetHealth ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__SetHealth
		               (int param1,longlong param2,longlong param3,undefined4 param4)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param3_00;
		  int iVar5;
		  undefined8 local_18;
		  longlong local_10;
		  longlong local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a5777f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a5777f = '\x01';
		  }
		  fVar1 = UnityEngine_Camera__set_orthographicSize((float)param2,(float)param3,0);
		  iVar5 = *(int *)(*(int *)(param1 + 0x28) + 0x18);
		  uVar2 = Core_Extensions_Dict_UserSkillDicExt__GetDescription(*(undefined4 *)(param1 + 0x30),0);
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
		  *(undefined4 *)(iVar5 + 0x28) = uVar2;
		  iVar3 = **(int **)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x108) * 4))
		            (*(int **)(param1 + 0x28),fVar1,*(undefined4 *)(iVar3 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x8FE4", Offset = "0x8FE4", VA = "0x8FE4")]
		private void SetMana(long current, long total)
		{
		/* --- GHIDRA: SetMana ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__SetMana(int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x34),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x34),0);
		  Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__SetHealth(param1,param2_00,param3,param1)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x8FE5", Offset = "0x8FE5", VA = "0x8FE5")]
		private void UpdateMana()
		{
		/* --- GHIDRA: UpdateMana ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__UpdateMana
		               (int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x34),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x34),0);
		  Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__Init(param1,param2_00,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x8FE6", Offset = "0x8FE6", VA = "0x8FE6")]
		private void UpdateHealth()
		{
		/* --- GHIDRA: UpdateHealth ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__UpdateHealth
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  
		  if (param2 != 3) {
		    if (param2 == 4) {
		      uVar1 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x34),0);
		      uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x34),0);
		      Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__SetHealth(param1,uVar1,uVar2,param1);
		    }
		    return;
		  }
		  uVar1 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x34),0);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x34),0);
		  Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__Init(param1,uVar1,uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x8FE7", Offset = "0x8FE7", VA = "0x8FE7", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x8FE8", Offset = "0x8FE8", VA = "0x8FE8", Slot = "6")]
		public void UpdateBalance()
		{
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x8FE9", Offset = "0x8FE9", VA = "0x8FE9", Slot = "7")]
		public void UpdateLongEffects()
		{
		/* --- GHIDRA: UpdateLongEffects ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__UpdateLongEffects
		               (undefined4 param1,float param2,float param3,undefined4 param4)
		
		{
		  return;
		}
		*/

		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x8FEA", Offset = "0x8FEA", VA = "0x8FEA", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x8FEB", Offset = "0x8FEB", VA = "0x8FEB", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
			return default(bool);
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x8FEC", Offset = "0x8FEC", VA = "0x8FEC", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDA")]
		public CombatPlayer Player
		{
			[Token(Token = "0x6004136")]
			[Address(RVA = "0x8FED", Offset = "0x8FED", VA = "0x8FED", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004137")]
			[Address(RVA = "0x8FEE", Offset = "0x8FEE", VA = "0x8FEE", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004138")]
		[Address(RVA = "0x8FEF", Offset = "0x8FEF", VA = "0x8FEF")]
		private void HandlePlayerChanged()
		{
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		// (set) Token: 0x0600413A RID: 16698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDB")]
		public bool IsInit
		{
			[Token(Token = "0x6004139")]
			[Address(RVA = "0x8FF0", Offset = "0x8FF0", VA = "0x8FF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600413A")]
			[Address(RVA = "0x8FF1", Offset = "0x8FF1", VA = "0x8FF1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600413B RID: 16699 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		// (set) Token: 0x0600413C RID: 16700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CDC")]
		public bool Select
		{
			[Token(Token = "0x600413B")]
			[Address(RVA = "0x8FF2", Offset = "0x8FF2", VA = "0x8FF2", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600413C")]
			[Address(RVA = "0x8FF3", Offset = "0x8FF3", VA = "0x8FF3", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600413D")]
		[Address(RVA = "0x8FF4", Offset = "0x8FF4", VA = "0x8FF4", Slot = "17")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x8FF5", Offset = "0x8FF5", VA = "0x8FF5")]
		public ClanCombatPlayerView()
		{
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600413F")]
		[Address(RVA = "0x8FF6", Offset = "0x8FF6", VA = "0x8FF6", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AprViewSmall _avatar;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI[] _nicks;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _myPlayerbackground;

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _background;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] _transformsOfMirror;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ProgressBar _healthBar;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ProgressBar _manaBar;

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x34")]
		private ClanCombatPlayer _player;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentManaUserSkillDic ---
		int Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__set_CurrentManaUserSkillDic
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__get_Player(param1,param2,param1);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,4,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,5,0);
		  *(undefined1 *)(param1 + 0x38) = 1;
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  return param1;
		}
		*/


		/* --- GHIDRA: get_Player ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__get_Player
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int param2_00;
		  uint uVar1;
		  
		  if (DAT_ram_00a57780 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		    DAT_ram_00a57780 = '\x01';
		  }
		  param2_00 = Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo;
		  if (param2 != *(int **)(param1 + 0x34)) {
		    if (param2 == (int *)0x0) {
		      *(undefined4 *)(param1 + 0x34) = 0;
		    }
		    else {
		      uVar1 = (uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8);
		      if ((*(byte *)(*param2 + 0xb8) < uVar1) ||
		         (*(int *)(*(int *)(*param2 + 100) + (uVar1 - 1) * 4) !=
		          Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo)) {
		code_r0x80dd7ca3:
		        System_Activator__CreateInstance(param2,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int **)(param1 + 0x34) = param2;
		      if ((*(byte *)(*param2 + 0xb8) < uVar1) ||
		         (*(int *)(*(int *)(*param2 + 100) + (uVar1 - 1) * 4) != param2_00)) goto code_r0x80dd7ca3;
		    }
		    Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__set_Player(param1,param2);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Player ---
		void Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__set_Player
		               (int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 in_i2q;
		  longlong lVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  undefined8 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  uint param2_00;
		  undefined4 uVar10;
		  int iVar11;
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_18;
		  undefined4 local_14;
		  undefined4 uStack_10;
		  float4 local_c;
		  undefined8 local_8;
		  
		  uVar2 = (uint)((ulonglong)in_i2q >> 0x20);
		  iVar9 = 0;
		  if (*(int *)(param1 + 0x34) != 0) {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(*(int *)(param1 + 0x34) + 0x54) ==
		                           *(int *)(*(int *)(*(int *)(param1 + 0x34) + 8) + 0x14)),0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),0);
		    param2_00 = (uint)(*(int *)(*(int *)(param1 + 0x34) + 0x54) !=
		                      *(int *)(*(int *)(*(int *)(param1 + 0x34) + 8) + 0x14));
		    uVar5 = CONCAT44(in_register_20000014,param2_00);
		    lVar1 = (ulonglong)uVar2 << 0x20;
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,param2_00,0);
		    iVar7 = *(int *)(param1 + 0x14);
		    if (0 < *(int *)(iVar7 + 0xc)) {
		      do {
		        uVar10 = (undefined4)((ulonglong)lVar1 >> 0x20);
		        piVar8 = *(int **)(iVar7 + iVar9 * 4 + 0x10);
		        uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        uVar4 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                          (*(undefined4 *)(*(int *)(param1 + 0x34) + 0x14),0);
		        iVar11 = *piVar8;
		        uVar5 = CONCAT44(uVar3,uVar4);
		        lVar1 = CONCAT44(uVar10,*(undefined4 *)(iVar11 + 0x2d4));
		        (**(code **)((ulonglong)*(uint *)(iVar11 + 0x2d0) * 4))(piVar8,uVar5,lVar1);
		        iVar9 = iVar9 + 1;
		      } while (iVar9 < *(int *)(iVar7 + 0xc));
		    }
		    uVar10 = (undefined4)((ulonglong)lVar1 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    iVar9 = *(int *)(param1 + 0x20);
		    if (0 < *(int *)(iVar9 + 0xc)) {
		      iVar7 = 0;
		      do {
		        uVar10 = *(undefined4 *)(iVar9 + iVar7 * 4 + 0x10);
		        uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        uVar2 = (uint)((ulonglong)lVar1 >> 0x20);
		        func_ii_20513(&local_c,uVar10,0);
		        local_14 = (undefined4)local_8;
		        uStack_10 = (undefined4)((ulonglong)local_8 >> 0x20);
		        local_20 = uStack_10;
		        local_18 = local_c;
		        if (*(int *)(*(int *)(*(int *)(param1 + 0x34) + 8) + 0x14) !=
		            *(int *)(*(int *)(param1 + 0x34) + 0x54)) {
		          local_18 = (float4)-(float)local_c;
		        }
		        local_28 = CONCAT44(local_14,local_18);
		        uVar5 = CONCAT44(uVar3,&local_28);
		        lVar1 = (ulonglong)uVar2 << 0x20;
		        Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar10,&local_28,0);
		        uVar10 = (undefined4)((ulonglong)lVar1 >> 0x20);
		        uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        iVar7 = iVar7 + 1;
		      } while (iVar7 < *(int *)(iVar9 + 0xc));
		    }
		    iVar9 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar9 + 0x138) * 4))
		              (*(int **)(param1 + 0x10),
		               CONCAT44(uVar3,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0x14) + 0x38)),
		               CONCAT44(uVar10,*(undefined4 *)(iVar9 + 0x13c)));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)*(byte *)(*(int *)(param1 + 0x34) + 0x65),0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(char *)(*(int *)(param1 + 0x34) + 0x65) == '\0'),0);
		    uVar5 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x34),0);
		    uVar6 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x34),0);
		    Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__Init(param1,uVar5,uVar6,auStack_30);
		    uVar5 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x34),0);
		    uVar6 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x34),0);
		    Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__SetHealth
		              (param1,uVar5,uVar6,auStack_30);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Select ---
		int Gameplay_Clans_Combat_View_Players_ClanCombatPlayerView__set_Select
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a57781 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanCombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanCombatPlayer__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanCombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12527);
		    DAT_ram_00a57781 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanCombatPlayer__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12527,Method_UI_ToolTip_ToolTipData_ClanCombatPlayer___ctor__);
		  param1_01 = *(int **)(param1 + 0x34);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8) * 4 +
		                -4) != Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(int **)(param1_00 + 0x1c) = param1_01;
		  return param1_00;
		}
		*/

}
