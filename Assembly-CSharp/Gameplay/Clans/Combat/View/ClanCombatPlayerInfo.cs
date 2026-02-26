using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Skills;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Combat.View.Players.LongEffects;
using Gameplay.Combat.View.Players.Pet;
using Gameplay.Sound.Control;
using Gameplay.UserInfo.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A93 RID: 2707
	[Token(Token = "0x2000A93")]
	public class ClanCombatPlayerInfo : MonoBehaviour, ICombatPLayerView
	{
		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CC4")]
		public SkillsInfo SkillsInfo
		{
			[Token(Token = "0x60040D8")]
			[Address(RVA = "0x8F8F", Offset = "0x8F8F", VA = "0x8F8F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060040D9 RID: 16601 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040DA RID: 16602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC5")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60040D9")]
			[Address(RVA = "0x8F90", Offset = "0x8F90", VA = "0x8F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040DA")]
			[Address(RVA = "0x8F91", Offset = "0x8F91", VA = "0x8F91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060040DB RID: 16603 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		// (set) Token: 0x060040DC RID: 16604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC6")]
		public bool IsInit
		{
			[Token(Token = "0x60040DB")]
			[Address(RVA = "0x8F92", Offset = "0x8F92", VA = "0x8F92", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040DC")]
			[Address(RVA = "0x8F93", Offset = "0x8F93", VA = "0x8F93")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040DE RID: 16606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC7")]
		public UserSkillDic CurrentHealUserSkillDic
		{
			[Token(Token = "0x60040DD")]
			[Address(RVA = "0x8F94", Offset = "0x8F94", VA = "0x8F94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040DE")]
			[Address(RVA = "0x8F95", Offset = "0x8F95", VA = "0x8F95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060040DF RID: 16607 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040E0 RID: 16608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC8")]
		public UserSkillDic CurrentManaUserSkillDic
		{
			[Token(Token = "0x60040DF")]
			[Address(RVA = "0x8F96", Offset = "0x8F96", VA = "0x8F96")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040E0")]
			[Address(RVA = "0x8F97", Offset = "0x8F97", VA = "0x8F97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CC9")]
		public LevelView Level
		{
			[Token(Token = "0x60040E1")]
			[Address(RVA = "0x8F98", Offset = "0x8F98", VA = "0x8F98")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CCA")]
		public RankView Rank
		{
			[Token(Token = "0x60040E2")]
			[Address(RVA = "0x8F99", Offset = "0x8F99", VA = "0x8F99")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060040E3 RID: 16611 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040E4 RID: 16612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCB")]
		public CombatPlayer Player
		{
			[Token(Token = "0x60040E3")]
			[Address(RVA = "0x8F9A", Offset = "0x8F9A", VA = "0x8F9A", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60040E4")]
			[Address(RVA = "0x8F9B", Offset = "0x8F9B", VA = "0x8F9B", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x8F9C", Offset = "0x8F9C", VA = "0x8F9C", Slot = "4")]
		public ICombatPLayerView Init(CombatPlayer player, IGameAudio gameAudio, Dictionaries dictionaries)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__Init(int param1,int param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined8 uVar2;
		  
		  if (param2 == 3) {
		    uVar1 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x4c),0);
		    uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x4c),0);
		    Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__UpdateMana(param1,uVar1,uVar2,param1);
		    return;
		  }
		  if (param2 == 4) {
		    uVar1 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x4c),0);
		    uVar2 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x4c),0);
		    Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetHealth(param1,uVar1,uVar2,param1);
		    return;
		  }
		  Gameplay_Combat_View_Players_SkillsInfo__OnEnable(*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x8F9D", Offset = "0x8F9D", VA = "0x8F9D", Slot = "5")]
		public void UpdateUserSkill(UserSkillsIndexes skillsIndex)
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x8F9E", Offset = "0x8F9E", VA = "0x8F9E", Slot = "6")]
		public void UpdateBalance()
		{
		/* --- GHIDRA: UpdateBalance ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__UpdateBalance(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  undefined4 param3;
		  int iVar5;
		  int iVar6;
		  int param1_00;
		  uint uVar7;
		  int *param1_01;
		  
		  if (DAT_ram_00a57766 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Combat_View_ClanCombatPlayerInfo_ResetPoolObjectDelegate__);
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
		    DAT_ram_00a57766 = '\x01';
		  }
		  if (*(int *)(param1 + 0x54) == 0) {
		    param2_00 = *(undefined4 *)(param1 + 0x2c);
		    param3 = *(undefined4 *)(*(int *)(param1 + 0x28) + 0x1c);
		    uVar4 = unnamed_function_1417
		                      (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_LongEffect__TypeInfo);
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (uVar4,param1,
		               Method_Gameplay_Clans_Combat_View_ClanCombatPlayerInfo_ResetPoolObjectDelegate__,0);
		    uVar2 = unnamed_function_1417(Utils_Cache_GameObjectPool_LongEffect__TypeInfo);
		    Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		              (uVar2,param2_00,param3,uVar4,Method_Utils_Cache_GameObjectPool_LongEffect___ctor__);
		    *(undefined4 *)(param1 + 0x54) = uVar2;
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
		      uVar4 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x24),iVar5,
		                         Method_System_Collections_Generic_List_EffectData__get_Item__);
		      uVar2 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                        (*(undefined4 *)(param1 + 0x54),
		                         Method_Utils_Cache_ObjectPool_LongEffect__Get__);
		      Gameplay_Combat_View_Players_LongEffects_LongEffect__get_Data(uVar2,uVar4,0);
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar2,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      iVar6 = Method_System_Collections_Generic_List_LongEffect__Add__;
		      param1_00 = *(int *)(param1 + 0x50);
		      *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		      uVar7 = *(uint *)(param1_00 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		        *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		        *(undefined4 *)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = uVar2;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar1);
		    if (0 < *(int *)(*(int *)(*(int *)(param1 + 0x4c) + 0x24) + 0xc)) {
		      uVar7 = 0;
		      param1_01 = *(int **)(param1 + 0x3c);
		      iVar1 = *param1_01;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Sound_Control_IGameAudio_TypeInfo ==
		              *(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8 + 4) * 8 + iVar1 + 200);
		            goto code_r0x80dd6afc;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_01,Gameplay_Sound_Control_IGameAudio_TypeInfo,1);
		code_r0x80dd6afc:
		      (**(code **)((ulonglong)*puVar3 * 4))(param1_01,0xe,puVar3[1]);
		    }
		  }
		  Gameplay_Combat_View_Players_LongEffects_LongEffectsView__get_LongEffectContainer
		            (*(undefined4 *)(param1 + 0x28),*(undefined4 *)(*(int *)(param1 + 0x50) + 0xc),0);
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(0 < *(int *)(*(int *)(param1 + 0x50) + 0xc)),0);
		  return;
		}
		*/

		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x8F9F", Offset = "0x8F9F", VA = "0x8F9F", Slot = "7")]
		public void UpdateLongEffects()
		{
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x8FA0", Offset = "0x8FA0", VA = "0x8FA0", Slot = "8")]
		public void ShowDeathState(float value, float duration = 0f)
		{
		/* --- GHIDRA: ShowDeathState ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__ShowDeathState
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param2 = *(undefined4 *)(param1 + 0x18);
		  return 1;
		}
		*/

		}

		// Token: 0x060040EA RID: 16618 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x60040EA")]
		[Address(RVA = "0x8FA1", Offset = "0x8FA1", VA = "0x8FA1", Slot = "9")]
		public bool TryGetLevel(out LevelView levelView)
		{
		/* --- GHIDRA: TryGetLevel ---
		undefined4
		Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__TryGetLevel
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57767 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57767 = '\x01';
		  }
		  *param2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x8FA2", Offset = "0x8FA2", VA = "0x8FA2", Slot = "10")]
		public bool TryGetPet(out IPetView petView)
		{
			return default(bool);
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x0000C810 File Offset: 0x0000AA10
		// (set) Token: 0x060040ED RID: 16621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCC")]
		public bool Select
		{
			[Token(Token = "0x60040EC")]
			[Address(RVA = "0x8FA3", Offset = "0x8FA3", VA = "0x8FA3", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040ED")]
			[Address(RVA = "0x8FA4", Offset = "0x8FA4", VA = "0x8FA4", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x8FA5", Offset = "0x8FA5", VA = "0x8FA5")]
		public void UpdateHealth()
		{
		/* --- GHIDRA: UpdateHealth ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__UpdateHealth(int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x4c),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetHealth(param1,param2_00,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x8FA6", Offset = "0x8FA6", VA = "0x8FA6")]
		public void UpdateMana()
		{
		/* --- GHIDRA: UpdateMana ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__UpdateMana
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
		  if (DAT_ram_00a57768 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57768 = '\x01';
		  }
		  fVar7 = 0.0;
		  if (param3 != 0) {
		    fVar7 = (float)param2 / (float)param3;
		  }
		  iVar8 = *(int *)(*(int *)(param1 + 0x30) + 0x18);
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
		  piVar9 = *(int **)(param1 + 0x30);
		  if (*(int *)(param1 + 0x38) == 1) {
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
		  iVar5 = **(int **)(param1 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x108) * 4))
		            (*(int **)(param1 + 0x30),fVar7,*(undefined4 *)(iVar5 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x8FA7", Offset = "0x8FA7", VA = "0x8FA7")]
		private void SetHealth(long current, long total)
		{
		/* --- GHIDRA: SetHealth ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetHealth
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
		  if (DAT_ram_00a57769 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a57769 = '\x01';
		  }
		  fVar7 = 0.0;
		  if (param3 != 0) {
		    fVar7 = (float)param2 / (float)param3;
		  }
		  iVar8 = *(int *)(*(int *)(param1 + 0x34) + 0x18);
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
		  piVar9 = *(int **)(param1 + 0x34);
		  if (*(int *)(param1 + 0x38) == 1) {
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
		  iVar5 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x108) * 4))
		            (*(int **)(param1 + 0x34),fVar7,*(undefined4 *)(iVar5 + 0x10c));
		  return;
		}
		*/

		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x8FA8", Offset = "0x8FA8", VA = "0x8FA8")]
		private void SetMana(long current, long total)
		{
		/* --- GHIDRA: SetMana ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetMana(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 in_i2q;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined8 uVar4;
		  undefined8 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int iVar10;
		  
		  uVar2 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  if (DAT_ram_00a5776a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11325);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11323);
		    DAT_ram_00a5776a = '\x01';
		  }
		  iVar8 = *(int *)(param1 + 0x4c);
		  *(int *)(*(int *)(param1 + 0x24) + 0x2c) = iVar8;
		  iVar10 = **(int **)(param1 + 0x10);
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 8) + 0xc) + 0x18))
		  ;
		  (**(code **)((ulonglong)*(uint *)(iVar10 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),uVar4,CONCAT44(uVar2,*(undefined4 *)(iVar10 + 0x2d4)));
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar6 = *(undefined4 *)(param1 + 0x14);
		  iVar8 = *(int *)(*(int *)(param1 + 0x4c) + 0x20);
		  if (iVar8 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80dd60fc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd60fc:
		    uVar4 = CONCAT44(uVar2,puVar3[1]);
		    uVar9 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar4);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar9 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar9,0);
		    uVar9 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar9,StringLiteral_11323,0);
		    Gameplay_UserInfo_View_CultView2___ctor(uVar6,uVar9,0);
		    uVar6 = *(undefined4 *)(param1 + 0x14);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80dd61c9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd61c9:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,CONCAT44(uVar2,puVar3[1]));
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    uVar2 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar2,StringLiteral_11325,0);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar6,uVar2,0);
		  }
		  else {
		    Gameplay_UserInfo_View_CultView2__get_CultDic(uVar6,iVar8,0);
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__set_User(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_UserInterface_View_LevelView__set_IsPremiumExp(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param1 + 0x1c);
		  uVar2 = Gameplay_Combat_Model_CombatPlayer__get_Level(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_UserInterface_View_LocationOwnerIndexView___ctor(uVar6,uVar2,0);
		  uVar4 = Gameplay_Combat_Model_CombatPlayer__SetPlayerSkills(*(undefined4 *)(param1 + 0x4c),0);
		  uVar5 = Gameplay_Combat_Model_CombatPlayer__get_CurrentMana(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetHealth(param1,uVar4,uVar5,param1);
		  uVar4 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x4c),0);
		  uVar5 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__UpdateMana(param1,uVar4,uVar5,param1);
		  uVar6 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (DAT_ram_00a57767 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57767 = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar8 = UnityEngine_Component__GetComponent_object_(piVar7,0);
		  if (iVar8 != 0) {
		    iVar8 = *(int *)(*(int *)(param1 + 0x4c) + 0x1c);
		    iVar10 = *piVar7;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo ==
		            *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8);
		          goto code_r0x80dd6329;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo,3);
		code_r0x80dd6329:
		    uVar1 = 0;
		    uVar4 = CONCAT44(uVar2,(uint)(iVar8 != 0));
		    uVar5 = CONCAT44(uVar6,puVar3[1]);
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar4,uVar5);
		    uVar6 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar9 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x1c);
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		          goto code_r0x80dd63b6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Gameplay_Combat_View_Players_Pet_IPetView_TypeInfo,5);
		code_r0x80dd63b6:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar7,CONCAT44(uVar2,uVar9),CONCAT44(uVar6,puVar3[1]));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x8FA9", Offset = "0x8FA9", VA = "0x8FA9")]
		private void HandlePlayerChanged()
		{
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x8FAA", Offset = "0x8FAA", VA = "0x8FAA")]
		private void ResetPoolObjectDelegate(LongEffect pooledobject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__ResetPoolObjectDelegate
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5776b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_LongEffect___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_LongEffect__TypeInfo);
		    DAT_ram_00a5776b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_LongEffect__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,10,Method_System_Collections_Generic_List_LongEffect___ctor__);
		  *(undefined4 *)(param1 + 0x50) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x8FAB", Offset = "0x8FAB", VA = "0x8FAB")]
		public ClanCombatPlayerInfo()
		{
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x8FAC", Offset = "0x8FAC", VA = "0x8FAC", Slot = "14")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x040023FE RID: 9214
		[Token(Token = "0x40023FE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x040023FF RID: 9215
		[Token(Token = "0x40023FF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CultWhitBackground _cultOnNickView;

		// Token: 0x04002400 RID: 9216
		[Token(Token = "0x4002400")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LevelView _level;

		// Token: 0x04002401 RID: 9217
		[Token(Token = "0x4002401")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RankView _rank;

		// Token: 0x04002402 RID: 9218
		[Token(Token = "0x4002402")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PetView _pet;

		// Token: 0x04002403 RID: 9219
		[Token(Token = "0x4002403")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillsInfo _skillsInfo;

		// Token: 0x04002404 RID: 9220
		[Token(Token = "0x4002404")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LongEffectsView _longEffectsView;

		// Token: 0x04002405 RID: 9221
		[Token(Token = "0x4002405")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LongEffect _longEffectPrefab;

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressBarWithText _healBar;

		// Token: 0x04002407 RID: 9223
		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ProgressBarWithText _manaBar;

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CombatPlayerView.SkillPbTextFormat _skillPbTextFormat;

		// Token: 0x0400240D RID: 9229
		[Token(Token = "0x400240D")]
		[FieldOffset(Offset = "0x4C")]
		private CombatPlayer _player;

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<LongEffect> _currentLongEffects;

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x54")]
		private GameObjectPool<LongEffect> _longEffectPool;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Player ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__get_Player
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x4c)) {
		    *(int *)(param1 + 0x4c) = param2;
		    Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetMana(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Player ---
		int Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__set_Player
		              (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  *(undefined4 *)(*(int *)(param1 + 0x24) + 0x28) = param4;
		  *(undefined4 *)(param1 + 0x3c) = param3;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,4,0);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___get_Item(param4,5,0);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  *(undefined4 *)(*(int *)(param1 + 0x20) + 0x10) = *(undefined4 *)(param1 + 0x44);
		  if (param2 != *(int *)(param1 + 0x4c)) {
		    *(int *)(param1 + 0x4c) = param2;
		    Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__SetMana(param1,param1);
		  }
		  *(undefined1 *)(param1 + 0x40) = 1;
		  return param1;
		}
		*/


		/* --- GHIDRA: set_Select ---
		void Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__set_Select(int param1,undefined4 param2)
		
		{
		  undefined8 param2_00;
		  undefined8 param3;
		  
		  param2_00 = Gameplay_Combat_Model_CombatPlayer__get_TotalMana(*(undefined4 *)(param1 + 0x4c),0);
		  param3 = Gameplay_Combat_Model_CombatPlayer__get_CurrentHealth(*(undefined4 *)(param1 + 0x4c),0);
		  Gameplay_Clans_Combat_View_ClanCombatPlayerInfo__UpdateMana(param1,param2_00,param3,param1);
		  return;
		}
		*/

}
