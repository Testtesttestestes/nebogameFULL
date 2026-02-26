using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using DefaultNamespace;
using Gameplay.Combat.Factories;
using Gameplay.Sound.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.Combat.Model
{
	// Token: 0x02000993 RID: 2451
	[Token(Token = "0x2000993")]
	public class CombatModel : AbstractModel
	{
		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x17000B71")]
		public virtual int SpellSlotsCount
		{
			[Token(Token = "0x6003A6C")]
			[Address(RVA = "0x89E2", Offset = "0x89E2", VA = "0x89E2", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x17000B72")]
		public virtual int ElixirsSlotsCount
		{
			[Token(Token = "0x6003A6D")]
			[Address(RVA = "0x89E3", Offset = "0x89E3", VA = "0x89E3", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x0000BA00 File Offset: 0x00009C00
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B73")]
		public int HandleGameOverCount
		{
			[Token(Token = "0x6003A6E")]
			[Address(RVA = "0x89E4", Offset = "0x89E4", VA = "0x89E4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A6F")]
			[Address(RVA = "0x89E5", Offset = "0x89E5", VA = "0x89E5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x0000BA18 File Offset: 0x00009C18
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B74")]
		public int RewardsGotCount
		{
			[Token(Token = "0x6003A70")]
			[Address(RVA = "0x89E6", Offset = "0x89E6", VA = "0x89E6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x89E7", Offset = "0x89E7", VA = "0x89E7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B75")]
		public Dictionary<ulong, CombatPlayer> Players
		{
			[Token(Token = "0x6003A72")]
			[Address(RVA = "0x89E8", Offset = "0x89E8", VA = "0x89E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x0000BA30 File Offset: 0x00009C30
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B76")]
		public bool IsAwaitSwapStonesResponse
		{
			[Token(Token = "0x6003A73")]
			[Address(RVA = "0x89E9", Offset = "0x89E9", VA = "0x89E9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A74")]
			[Address(RVA = "0x89EA", Offset = "0x89EA", VA = "0x89EA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B77")]
		public virtual CombatPlayer MyPlayer
		{
			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x89EB", Offset = "0x89EB", VA = "0x89EB", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B78")]
		public CombatSpellData CurrentSelectedSpell
		{
			[Token(Token = "0x6003A76")]
			[Address(RVA = "0x89EC", Offset = "0x89EC", VA = "0x89EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x89ED", Offset = "0x89ED", VA = "0x89ED")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B79")]
		public JoinToCombatInfo JoinToCombatInfo
		{
			[Token(Token = "0x6003A78")]
			[Address(RVA = "0x89EE", Offset = "0x89EE", VA = "0x89EE")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A79")]
			[Address(RVA = "0x89EF", Offset = "0x89EF", VA = "0x89EF")]
			set
			{
			}
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A7A")]
		[Address(RVA = "0x89F0", Offset = "0x89F0", VA = "0x89F0")]
		private void HandleJoinToCombatInfoChanged()
		{
		/* --- GHIDRA: HandleJoinToCombatInfoChanged ---
		undefined4
		Gameplay_Combat_Model_CombatModel__HandleJoinToCombatInfoChanged
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57e31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		    DAT_ram_00a57e31 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x30);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar1,param2_00,
		                         Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		      *param3 = iVar1;
		      iVar1 = Google_Protobuf_Reflection_EnumDescriptorProto_Types_EnumReservedRange__Equals
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x38) + 0xc),param2,0);
		      if (iVar1 != 0) {
		        return 1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x30);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  *param3 = 0;
		  return 0;
		}
		*/

		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x6003A7B")]
		[Address(RVA = "0x89F1", Offset = "0x89F1", VA = "0x89F1")]
		public bool TryGetEventSpell(SpellKey spellKey, out CombatSpellData spell)
		{
		/* --- GHIDRA: TryGetEventSpell ---
		undefined4
		Gameplay_Combat_Model_CombatModel__TryGetEventSpell
		          (undefined4 param1,int *param2,undefined4 param3,int *param4,int param5,undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57e32 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_ICombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a57e32 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param5 + 0xc);
		  iVar4 = *param4;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e6b5f5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param4,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80e6b5f5:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param4,uVar3,puVar2[1]);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Combat_Factories_ICombatPlayerFactory_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e6b67f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Combat_Factories_ICombatPlayerFactory_TypeInfo,0);
		code_r0x80e6b67f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,param5,uVar3,param3,puVar2[1]);
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x89F2", Offset = "0x89F2", VA = "0x89F2", Slot = "9")]
		protected virtual CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
		/* --- GHIDRA: CreatePlayer ---
		int Gameplay_Combat_Model_CombatModel__CreatePlayer(int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57e33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_CombatPlayer___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_CombatPlayer___);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatPlayer__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass37_0__GetTurnState_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass37_0__GetTurnState_b__1__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel___c__DisplayClass37_0_TypeInfo);
		    DAT_ram_00a57e33 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Combat_Model_CombatModel___c__DisplayClass37_0_TypeInfo);
		  *(undefined8 *)(param2_00 + 0x10) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (param1[7],
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  uVar2 = unnamed_function_1417(System_Func_CombatPlayer__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param2_00,
		             Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass37_0__GetTurnState_b__0__,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,uVar2,Method_System_Linq_Enumerable_Where_CombatPlayer___);
		  uVar2 = unnamed_function_1417(System_Func_CombatPlayer__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param2_00,
		             Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass37_0__GetTurnState_b__1__,0);
		  iVar3 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (uVar1,uVar2,Method_System_Linq_Enumerable_Any_CombatPlayer___);
		  if (iVar3 != 0) {
		    uVar1 = 3;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(longlong *)(*(int *)(*(int *)(iVar3 + 8) + 0xc) + 0x10) != *(longlong *)(param2_00 + 0x10)
		       ) {
		      uVar1 = 1;
		    }
		    return uVar1;
		  }
		  return (uint)(*(longlong *)(param2_00 + 0x10) != 0) << 1;
		}
		*/

			return null;
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x89F3", Offset = "0x89F3", VA = "0x89F3", Slot = "10")]
		public virtual TurnStates GetTurnState(ulong userId)
		{
		/* --- GHIDRA: GetTurnState ---
		uint Gameplay_Combat_Model_CombatModel__GetTurnState(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined8 *)(param1[0xd] + 0x10),*(undefined4 *)(*param1 + 0x114));
		  return (uint)(iVar1 == 3);
		}
		*/

			return TurnStates.NoTurn;
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06003A7E RID: 14974 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x17000B7A")]
		public bool IsMyTurn
		{
			[Token(Token = "0x6003A7E")]
			[Address(RVA = "0x89F4", Offset = "0x89F4", VA = "0x89F4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x89F5", Offset = "0x89F5", VA = "0x89F5")]
		private void AppendModsToCache(CombatPlayer player)
		{
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7B")]
		public CombatDependencies Dependencies
		{
			[Token(Token = "0x6003A80")]
			[Address(RVA = "0x89F6", Offset = "0x89F6", VA = "0x89F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A81")]
			[Address(RVA = "0x89F7", Offset = "0x89F7", VA = "0x89F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7C")]
		public BackTime AwaitCombatBackTime
		{
			[Token(Token = "0x6003A82")]
			[Address(RVA = "0x89F8", Offset = "0x89F8", VA = "0x89F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A83")]
			[Address(RVA = "0x89F9", Offset = "0x89F9", VA = "0x89F9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7D")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6003A84")]
			[Address(RVA = "0x89FA", Offset = "0x89FA", VA = "0x89FA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A85")]
			[Address(RVA = "0x89FB", Offset = "0x89FB", VA = "0x89FB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7E")]
		public Dictionary<ulong, ProtoSkillsChangedEvt> ResurrectedUsers
		{
			[Token(Token = "0x6003A86")]
			[Address(RVA = "0x89FC", Offset = "0x89FC", VA = "0x89FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003A87")]
			[Address(RVA = "0x89FD", Offset = "0x89FD", VA = "0x89FD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x0000BA90 File Offset: 0x00009C90
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B7F")]
		public bool IsFieldCleared
		{
			[Token(Token = "0x6003A88")]
			[Address(RVA = "0x89FE", Offset = "0x89FE", VA = "0x89FE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A89")]
			[Address(RVA = "0x89FF", Offset = "0x89FF", VA = "0x89FF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x6003A8A")]
		[Address(RVA = "0x8A00", Offset = "0x8A00", VA = "0x8A00", Slot = "11")]
		public virtual PlayLists GetPlayList()
		{
			return PlayLists.UNKNOWN;
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8B")]
		[Address(RVA = "0x8A01", Offset = "0x8A01", VA = "0x8A01", Slot = "12")]
		public virtual ResourceSet GetNextCombatCost()
		{
		/* --- GHIDRA: GetNextCombatCost ---
		undefined4
		Gameplay_Combat_Model_CombatModel__GetNextCombatCost
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  int param1_01;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a57e35 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CombatEventData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CombatEventData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__CombatEventData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__CombatEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CombatEventDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CombatEventDic__get_Item__);
		    DAT_ram_00a57e35 = '\x01';
		  }
		  if (param1[0x16] == 0) {
		    uVar1 = 0;
		    iVar2 = unnamed_function_1417
		                      (System_Collections_Generic_Dictionary_uint__CombatEventData__TypeInfo);
		    System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		              (iVar2,Method_System_Collections_Generic_Dictionary_uint__CombatEventData___ctor__);
		    param1[0x16] = iVar2;
		    param1_00 = *(int **)(param1[0xf] + 0x18);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x80e6bbb6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6bbb6:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = *(int *)(iVar2 + 600);
		    iVar6 = *(int *)(iVar2 + 0xc);
		    if (0 < iVar6) {
		      param2_00 = 0;
		      do {
		        iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar2,param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_CombatEventDic__get_Item__
		                          );
		        param1_01 = param1[0x16];
		        param2_01 = *(undefined4 *)(iVar4 + 0xc);
		        uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))
		                          (param1,iVar4,*(undefined4 *)(*param1 + 300));
		        System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                  (param1_01,param2_01,uVar5,
		                   Method_System_Collections_Generic_Dictionary_uint__CombatEventData__Add__);
		        param2_00 = param2_00 + 1;
		      } while (param2_00 != iVar6);
		    }
		  }
		  uVar5 = System_Collections_Generic_List_object___get_Item
		                    (param1[0x16],param2,
		                     Method_System_Collections_Generic_Dictionary_uint__CombatEventData__get_Item__)
		  ;
		  return uVar5;
		}
		*/

			return null;
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8C")]
		[Address(RVA = "0x8A02", Offset = "0x8A02", VA = "0x8A02")]
		public CombatEventData GetCombatEvent(uint id)
		{
		/* --- GHIDRA: GetCombatEvent ---
		int Gameplay_Combat_Model_CombatModel__GetCombatEvent
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57e36 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatEventData_TypeInfo);
		    DAT_ram_00a57e36 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Combat_Model_CombatEventData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8D")]
		[Address(RVA = "0x8A03", Offset = "0x8A03", VA = "0x8A03", Slot = "13")]
		protected virtual CombatEventData CreateCombatEventData(CombatEventDic dict)
		{
		/* --- GHIDRA: CreateCombatEventData ---
		uint Gameplay_Combat_Model_CombatModel__CreateCombatEventData
		               (int *param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  return (uint)(*(longlong *)(*(int *)(*(int *)(iVar1 + 8) + 0xc) + 0x10) == param2);
		}
		*/

			return null;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x6003A8E")]
		[Address(RVA = "0x8A04", Offset = "0x8A04", VA = "0x8A04", Slot = "14")]
		public virtual bool GetSpellsEnabled(ulong userId)
		{
		/* --- GHIDRA: GetSpellsEnabled ---
		int Gameplay_Combat_Model_CombatModel__GetSpellsEnabled(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *param3_00;
		  undefined4 uVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57e37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__Add__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57e37 = '\x01';
		  }
		  iVar4 = param1[0xf];
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x108) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(iVar4 + 8)),
		                     *(undefined4 *)(iVar4 + 0xc),*(undefined4 *)(iVar4 + 0x10),param2,
		                     *(undefined4 *)(*param1 + 0x10c));
		  param2_00 = *(undefined8 *)(*(int *)(param2 + 0xc) + 0x10);
		  BestHTTP_Caching_HTTPCacheFileInfo___ctor
		            (param1[7],param2_00,iVar4,
		             Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__Add__);
		  uVar2 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  *(undefined4 *)(iVar4 + 0x54) = *(undefined4 *)(param1[3] + 0x2c);
		  param1_00 = *(int **)(param1[0xf] + 0x18);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80e6bd8d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param3_00 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6bd8d:
		  uVar2 = (**(code **)((ulonglong)*param3_00 * 4))(param1_00,CONCAT44(uVar2,param3_00[1]));
		  uVar2 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                    (uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 8) + 0xc) + 0x24),0);
		  *(undefined4 *)(iVar4 + 0x20) = uVar2;
		  Gameplay_Combat_Model_CombatModel__get_IsMyTurn(param1,iVar4,param3_00);
		  return iVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A8F")]
		[Address(RVA = "0x8A05", Offset = "0x8A05", VA = "0x8A05", Slot = "15")]
		public virtual CombatPlayer AddPlayer(PlayerInfo playerInfo)
		{
		/* --- GHIDRA: AddPlayer ---
		undefined4
		Gameplay_Combat_Model_CombatModel__AddPlayer
		          (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57e38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__TryGetValue__);
		    DAT_ram_00a57e38 = '\x01';
		  }
		  iVar1 = func_ii_7090(*(undefined4 *)(param1 + 0x1c),param2,param3,
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__TryGetValue__
		                      );
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		              (*(undefined4 *)(param1 + 0x38),param2,
		               Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____Remove__
		              );
		    uVar2 = Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		                      (*(undefined4 *)(param1 + 0x1c),param2,
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__Remove__);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x6003A90")]
		[Address(RVA = "0x8A06", Offset = "0x8A06", VA = "0x8A06", Slot = "16")]
		public virtual bool RemovePlayer(ulong userId, out CombatPlayer player)
		{
		/* --- GHIDRA: RemovePlayer ---
		undefined4 Gameplay_Combat_Model_CombatModel__RemovePlayer(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  uint uVar9;
		  undefined4 *puVar10;
		  
		  if (DAT_ram_00a57e39 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_GameFieldGemSetsDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_GameFieldGemSetsDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_CombatTypeGemSetsDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_CombatTypeGemSetsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_GameFieldGemSetsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_CombatTypeGemSetsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_Model_CombatModel___c__GetGameFieldGemSetDic_b__73_2__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass73_0__GetGameFieldGemSetDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass73_0__GetGameFieldGemSetDic_b__1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel___c__DisplayClass73_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel___c_TypeInfo);
		    DAT_ram_00a57e39 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Combat_Model_CombatModel___c__DisplayClass73_0_TypeInfo);
		  *(int *)(iVar2 + 8) = *(int *)(*(int *)(param1 + 0xc) + 0xc) + 1;
		  piVar5 = *(int **)(*(int *)(param1 + 0x3c) + 0x18);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e6bf43;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6bf43:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 200);
		  uVar4 = unnamed_function_1417(System_Func_CombatTypeGemSetsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar4,iVar2,
		             Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass73_0__GetGameFieldGemSetDic_b__0__
		             ,0);
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar7,uVar4,Method_System_Linq_Enumerable_Where_CombatTypeGemSetsDic___);
		  iVar6 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_CombatTypeGemSetsDic___);
		  *(int *)(iVar2 + 0xc) = iVar6;
		  piVar5 = *(int **)(*(int *)(param1 + 0x3c) + 0x18);
		  iVar8 = *piVar5;
		  uVar9 = (uint)*(ushort *)(iVar8 + 0xb6);
		  if (*(int *)(iVar6 + 0xc) != 0) {
		    if (uVar9 != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		          goto code_r0x80e6c019;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar9 != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6c019:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar7 = *(undefined4 *)(iVar6 + 0xc4);
		    uVar4 = unnamed_function_1417(System_Func_GameFieldGemSetsDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar2,
		               Method_Gameplay_Combat_Model_CombatModel___c__DisplayClass73_0__GetGameFieldGemSetDic_b__1__
		               ,0);
		    uVar4 = func_ii_6917(uVar7,uVar4,Method_System_Linq_Enumerable_Single_GameFieldGemSetsDic___);
		    return uVar4;
		  }
		  if (uVar9 != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x80e6c0b4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (uVar9 != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6c0b4:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = *(undefined4 *)(iVar2 + 0xc4);
		  if (*(int *)(Gameplay_Combat_Model_CombatModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Combat_Model_CombatModel___c_TypeInfo);
		  }
		  puVar10 = *(undefined4 **)(Gameplay_Combat_Model_CombatModel___c_TypeInfo + 0x5c);
		  iVar2 = puVar10[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Combat_Model_CombatModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Combat_Model_CombatModel___c_TypeInfo);
		      puVar10 = *(undefined4 **)(Gameplay_Combat_Model_CombatModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar10;
		    iVar2 = unnamed_function_1417(System_Func_GameFieldGemSetsDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,uVar7,
		               Method_Gameplay_Combat_Model_CombatModel___c__GetGameFieldGemSetDic_b__73_2__,0);
		    *(int *)(*(int *)(Gameplay_Combat_Model_CombatModel___c_TypeInfo + 0x5c) + 4) = iVar2;
		  }
		  uVar4 = func_ii_7423(uVar4,iVar2,Method_System_Linq_Enumerable_First_GameFieldGemSetsDic___);
		  return uVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A91")]
		[Address(RVA = "0x8A07", Offset = "0x8A07", VA = "0x8A07")]
		public GameFieldGemSetsDic GetGameFieldGemSetDic()
		{
		/* --- GHIDRA: GetGameFieldGemSetDic ---
		undefined4 Gameplay_Combat_Model_CombatModel__GetGameFieldGemSetDic(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  
		  if ((*(int *)(param1 + 0x40) == 0) ||
		     (fVar1 = func_ii_7103(*(int *)(param1 + 0x40),0), fVar1 <= 0.0)) {
		    uVar2 = 3;
		    if (*(int *)(param1 + 0x10) == 0) {
		      uVar2 = 2;
		    }
		  }
		  else {
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x6003A92")]
		[Address(RVA = "0x8A08", Offset = "0x8A08", VA = "0x8A08")]
		public CombatModel.States GetState()
		{
		/* --- GHIDRA: GetState ---
		void Gameplay_Combat_Model_CombatModel__GetState(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  int iVar3;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e3a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_ulong__CombatPlayer__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData__Clear__);
		    DAT_ram_00a57e3a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  iVar2 = *(int *)(param1 + 0x30);
		  iVar3 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar3) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar3,0);
		  }
		  Gameplay_Combat_Model_CombatDependencies___ctor(*(undefined4 *)(param1 + 0x3c),&local_30);
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_28,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__GetEnumerator__);
		  local_30 = 0;
		  local_2c = &local_28;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d5,&local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e6c31a;
		    }
		    if (iVar3 == 0) goto code_r0x80e6c370;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (*(undefined4 *)(*(int *)local_10 + 0xe8),(int *)local_10,
		               *(undefined4 *)(*(int *)local_10 + 0xec));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e6c31a:
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar1 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar1;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e6c370:
		      DAT_ram_009d3e38 = 0;
		      *(undefined8 *)(param1 + 0x3c) = 0;
		      *(undefined4 *)(param1 + 0x58) = 0;
		      *(undefined8 *)(param1 + 0x50) = 0;
		      *(undefined8 *)(param1 + 0xc) = 0;
		      *(undefined4 *)(param1 + 0x44) = 0;
		      Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xb2,&local_30);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return CombatModel.States.None;
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x8A09", Offset = "0x8A09", VA = "0x8A09", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Combat_Model_CombatModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ProtoSkillsChangedEvt___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__ProtoSkillsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_GameFieldGamesData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatSpellData__TypeInfo);
		    DAT_ram_00a57e3b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_ulong__CombatPlayer__TypeInfo)
		  ;
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(Gameplay_Combat_Model_GameFieldGamesData_TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_CombatSpellData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_CombatSpellData___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData_____ctor__
		            );
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__ProtoSkillsChangedEvt__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_ulong__ProtoSkillsChangedEvt___ctor__);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param5,0);
		  *(undefined4 *)(param1 + 0x44) = param4;
		  *(undefined4 *)(param1 + 0x40) = param3;
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A94")]
		[Address(RVA = "0x8A0A", Offset = "0x8A0A", VA = "0x8A0A")]
		public CombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_Model_CombatModel___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e3c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel___c_TypeInfo);
		    DAT_ram_00a57e3c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Combat_Model_CombatModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Combat_Model_CombatModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002040 RID: 8256
		[Token(Token = "0x4002040")]
		[FieldOffset(Offset = "0xC")]
		private JoinToCombatInfo _joinToCombatInfo;

		// Token: 0x04002041 RID: 8257
		[Token(Token = "0x4002041")]
		[FieldOffset(Offset = "0x10")]
		public GameOverData GameOver;

		// Token: 0x04002046 RID: 8262
		[Token(Token = "0x4002046")]
		[FieldOffset(Offset = "0x24")]
		protected CombatPlayer _myPlayer;

		// Token: 0x04002048 RID: 8264
		[Token(Token = "0x4002048")]
		[FieldOffset(Offset = "0x2C")]
		public readonly GameFieldGamesData FieldData;

		// Token: 0x04002049 RID: 8265
		[Token(Token = "0x4002049")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<CombatSpellData> _eventSpells;

		// Token: 0x0400204A RID: 8266
		[Token(Token = "0x400204A")]
		[FieldOffset(Offset = "0x34")]
		public ProtoSwitchTurnEvt CurrentTurn;

		// Token: 0x0400204B RID: 8267
		[Token(Token = "0x400204B")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<ulong, Dictionary<string, List<ModifierData>>> ActiveArtifactsCachByUserId;

		// Token: 0x04002051 RID: 8273
		[Token(Token = "0x4002051")]
		[FieldOffset(Offset = "0x50")]
		public Scenes[] ScenesForUnload;

		// Token: 0x04002052 RID: 8274
		[Token(Token = "0x4002052")]
		[FieldOffset(Offset = "0x54")]
		public Scenes[] TargetScenes;

		// Token: 0x04002053 RID: 8275
		[Token(Token = "0x4002053")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<uint, CombatEventData> _combatEventDicCache;

		// Token: 0x02000994 RID: 2452
		[Token(Token = "0x2000994")]
		public enum States
		{
			// Token: 0x04002055 RID: 8277
			[Token(Token = "0x4002055")]
			None,
			// Token: 0x04002056 RID: 8278
			[Token(Token = "0x4002056")]
			Await,
			// Token: 0x04002057 RID: 8279
			[Token(Token = "0x4002057")]
			Process,
			// Token: 0x04002058 RID: 8280
			[Token(Token = "0x4002058")]
			Complete
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsAwaitSwapStonesResponse ---
		int Gameplay_Combat_Model_CombatModel__set_IsAwaitSwapStonesResponse(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    DAT_ram_00a57e2f = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar4 = *(int *)(param1 + 0x24);
		  if (iVar4 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(undefined4 *)(param1 + 0x1c),
		                       Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__
		                      );
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_10,uVar1,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    local_18 = 0;
		    local_14 = &local_10;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                        );
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar4 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar4 == iVar2) {
		          piVar3 = (int *)import::env::__cxa_begin_catch(uVar1);
		          iVar2 = *piVar3;
		          DAT_ram_009d3e38 = 0;
		          local_18 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) {
		            if (iVar2 != 0) {
		              System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            goto code_r0x80e6b09f;
		          }
		          uVar1 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xb1,&local_18);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar2 == 0) goto code_r0x80e6b09f;
		    } while (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != *(int *)(*(int *)(local_8._4_4_ + 8) + 0x14)
		            );
		    *(int *)(param1 + 0x24) = local_8._4_4_;
		code_r0x80e6b09f:
		    iVar4 = *(int *)(param1 + 0x24);
		  }
		  return iVar4;
		}
		*/


		/* --- GHIDRA: get_JoinToCombatInfo ---
		void Gameplay_Combat_Model_CombatModel__get_JoinToCombatInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0xc)) {
		    *(int *)(param1 + 0xc) = param2;
		    Gameplay_Combat_Model_CombatModel__set_JoinToCombatInfo(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_JoinToCombatInfo ---
		void Gameplay_Combat_Model_CombatModel__set_JoinToCombatInfo(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  
		  if (DAT_ram_00a57e30 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Factories_ICombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatSpellData__Clear__);
		    Mono_Security_ASN1__get_Item(&Protocol_Combat_ProtoSwitchTurnEvt_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PlayerInfo__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Item__);
		    DAT_ram_00a57e30 = '\x01';
		  }
		  if (param1[3] != 0) {
		    iVar4 = param1[0xc];
		    iVar5 = *(int *)(iVar4 + 0xc);
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    if (0 < iVar5) {
		      func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar5,0);
		    }
		    iVar4 = param1[0xb];
		    piVar6 = *(int **)(param1[0xf] + 0x18);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80e6b23b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6b23b:
		    uVar1 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar3 = Core_Extensions_Dict_DictExt__GetEffectLevelDic
		                      (uVar3,*(undefined4 *)(param1[3] + 0xc),0);
		    *(undefined4 *)(iVar4 + 0xc) = uVar3;
		    iVar4 = param1[0xb];
		    piVar6 = *(int **)(param1[0xf] + 0x18);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80e6b2db;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e6b2db:
		    iVar5 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar3 = Core_Extensions_Dict_DictExt__GetGemsSetByCombatType
		                      (uVar3,*(undefined4 *)(param1[0xb] + 0xc),0);
		    *(undefined4 *)(iVar4 + 8) = uVar3;
		    iVar4 = param1[0xb];
		    iVar7 = param1[3];
		    iVar8 = *(int *)(iVar7 + 0x28);
		    iVar9 = *(int *)(iVar8 + 0x14);
		    if (iVar9 == 0) {
		      iVar9 = 6;
		    }
		    *(int *)(iVar4 + 0x10) = iVar9;
		    iVar8 = *(int *)(iVar8 + 0x10);
		    if (iVar8 == 0) {
		      iVar8 = 6;
		    }
		    *(int *)(iVar4 + 0x14) = iVar8;
		    iVar4 = *(int *)(*(int *)(iVar7 + 0x30) + 0xc);
		    if (0 < iVar4) {
		      do {
		        uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1[3] + 0x30),iVar5,
		                           Method_Google_Protobuf_Collections_RepeatedField_PlayerInfo__get_Item__);
		        (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                  (param1,uVar3,*(undefined4 *)(*param1 + 0x13c));
		        iVar5 = iVar5 + 1;
		      } while (iVar5 != iVar4);
		    }
		    iVar4 = 0;
		    iVar5 = unnamed_function_1417(Protocol_Combat_ProtoSwitchTurnEvt_TypeInfo);
		    param1[0xd] = iVar5;
		    iVar7 = param1[3];
		    *(undefined8 *)(iVar5 + 0x10) = *(undefined8 *)(iVar7 + 0x20);
		    *(undefined4 *)(iVar5 + 0x18) = *(undefined4 *)(iVar7 + 0x18);
		    iVar5 = *(int *)(*(int *)(iVar7 + 0x44) + 0xc);
		    if (0 < iVar5) {
		      do {
		        uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1[3] + 0x44),iVar4,
		                           Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Item__)
		        ;
		        iVar7 = param1[0xc];
		        piVar6 = *(int **)(param1[0xf] + 0xc);
		        iVar8 = *piVar6;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		            if (Gameplay_Combat_Factories_ICombatSpellDataFactory_TypeInfo == *piVar10) {
		              puVar2 = (uint *)(iVar8 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x80e6b450;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar6,
		                                      Gameplay_Combat_Factories_ICombatSpellDataFactory_TypeInfo,0);
		code_r0x80e6b450:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,uVar3,puVar2[1]);
		        iVar8 = Method_System_Collections_Generic_List_CombatSpellData__Add__;
		        *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar7 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		          *(uint *)(iVar7 + 0xc) = uVar1 + 1;
		          *(undefined4 *)(*(int *)(iVar7 + 8) + uVar1 * 4 + 0x10) = uVar3;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar7,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        }
		        iVar4 = iVar4 + 1;
		      } while (iVar4 != iVar5);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_IsMyTurn ---
		void Gameplay_Combat_Model_CombatModel__get_IsMyTurn(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 param1_01;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  uint uVar10;
		  int param2_01;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a57e34 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__List_ModifierData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__List_ModifierData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__List_ModifierData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__List_ModifierData___get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__List_ModifierData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ModifierData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ModifierData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellCombat__get_Count__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19176);
		    DAT_ram_00a57e34 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param1_00 = Core_Data_ModifierData__AddModificator(*(undefined4 *)(*(int *)(param2 + 8) + 0x24),0)
		  ;
		  iVar1 = func_ii_7090(*(undefined4 *)(param1 + 0x38),
		                       *(undefined8 *)(*(int *)(*(int *)(param2 + 8) + 0xc) + 0x10),&local_4,
		                       Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____TryGetValue__
		                      );
		  if (iVar1 == 0) {
		    uVar2 = unnamed_function_1417
		                      (System_Collections_Generic_Dictionary_string__List_ModifierData___TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar2,
		               Method_System_Collections_Generic_Dictionary_string__List_ModifierData____ctor__);
		    local_4 = uVar2;
		    BestHTTP_Caching_HTTPCacheFileInfo___ctor
		              (*(undefined4 *)(param1 + 0x38),
		               *(undefined8 *)(*(int *)(*(int *)(param2 + 8) + 0xc) + 0x10),uVar2,
		               Method_System_Collections_Generic_Dictionary_ulong__Dictionary_string__List_ModifierData____Add__
		              );
		  }
		  iVar1 = *(int *)(param1_00 + 0xc);
		  if (0 < iVar1) {
		    do {
		      uVar2 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,param2_01,
		                         Method_System_Collections_Generic_List_ModifierData__get_Item__);
		      param2_00 = 0;
		      iVar9 = *(int *)(*(int *)(*(int *)(param2 + 8) + 0x20) + 0xc);
		      if (0 < iVar9) {
		        do {
		          iVar3 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param2 + 0xc),param2_00,
		                             Method_System_Collections_Generic_List_CombatSpellData__get_Item__);
		          local_8 = UnityEngine_AndroidJavaObject___GetRawObject(iVar3,0);
		          uVar4 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		          local_8 = com_unity3d_mediation_LevelPlayBannerAd___ctor(uVar2,0);
		          uVar5 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_8,0);
		          uVar5 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                            (uVar4,StringLiteral_19176,uVar5,0);
		          iVar6 = System_Xml_Schema_SchemaInfo__get_Notations
		                            (local_4,uVar5,
		                             Method_System_Collections_Generic_Dictionary_string__List_ModifierData___ContainsKey__
		                            );
		          uVar4 = local_4;
		          if (iVar6 == 0) {
		            param1_01 = unnamed_function_1417
		                                  (System_Collections_Generic_List_ModifierData__TypeInfo);
		            GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                      (param1_01,Method_System_Collections_Generic_List_ModifierData___ctor__);
		            System_Reflection_FieldInfo__get_IsStatic
		                      (uVar4,uVar5,param1_01,
		                       Method_System_Collections_Generic_Dictionary_string__List_ModifierData___Add__
		                      );
		            iVar7 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl(uVar2,0);
		            iVar8 = UnityEngine_AndroidJavaObject___GetRawObject(iVar3,0);
		            iVar6 = Method_System_Collections_Generic_List_ModifierData__Add__;
		            if (iVar7 == iVar8) {
		              iVar3 = *(int *)(iVar3 + 0x44);
		              *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		              uVar10 = *(uint *)(iVar3 + 0xc);
		              if (uVar10 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		                *(uint *)(iVar3 + 0xc) = uVar10 + 1;
		                *(undefined4 *)(*(int *)(iVar3 + 8) + uVar10 * 4 + 0x10) = uVar2;
		              }
		              else {
		                System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                          (iVar3,uVar2,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		              }
		              iVar6 = System_Data_DataRelationCollection__Add
		                                (local_4,uVar5,
		                                 Method_System_Collections_Generic_Dictionary_string__List_ModifierData___get_Item__
		                                );
		              iVar3 = Method_System_Collections_Generic_List_ModifierData__Add__;
		              *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		              uVar10 = *(uint *)(iVar6 + 0xc);
		              if (uVar10 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		                *(uint *)(iVar6 + 0xc) = uVar10 + 1;
		                *(undefined4 *)(*(int *)(iVar6 + 8) + uVar10 * 4 + 0x10) = uVar2;
		              }
		              else {
		                System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                          (iVar6,uVar2,
		                           *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		              }
		            }
		          }
		          param2_00 = param2_00 + 1;
		        } while (param2_00 != iVar9);
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar1);
		  }
		  return;
		}
		*/

}
