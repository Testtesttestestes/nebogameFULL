using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Core.Gameplay.Managers.Requirements;
using Gameplay.Clans.ClanWars;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.Model;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.Clans.Combat.Model
{
	// Token: 0x02000A9C RID: 2716
	[Token(Token = "0x2000A9C")]
	public class ClanCombatModel : TeamCombatModel
	{
		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004153 RID: 16723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE3")]
		public IClanWars ClanWars
		{
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x9009", Offset = "0x9009", VA = "0x9009")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x900A", Offset = "0x900A", VA = "0x900A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		// (set) Token: 0x06004155 RID: 16725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE4")]
		public bool IsViewMode
		{
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x900B", Offset = "0x900B", VA = "0x900B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004155")]
			[Address(RVA = "0x900C", Offset = "0x900C", VA = "0x900C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06004156 RID: 16726 RVA: 0x0000C900 File Offset: 0x0000AB00
		// (set) Token: 0x06004157 RID: 16727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE5")]
		public bool IsJoinProcess
		{
			[Token(Token = "0x6004156")]
			[Address(RVA = "0x900D", Offset = "0x900D", VA = "0x900D")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004157")]
			[Address(RVA = "0x900E", Offset = "0x900E", VA = "0x900E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004159 RID: 16729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE6")]
		public RequirementsManager RequirementsManager
		{
			[Token(Token = "0x6004158")]
			[Address(RVA = "0x900F", Offset = "0x900F", VA = "0x900F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004159")]
			[Address(RVA = "0x9010", Offset = "0x9010", VA = "0x9010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CE7")]
		public override CombatPlayer MyPlayer
		{
			[Token(Token = "0x600415A")]
			[Address(RVA = "0x9011", Offset = "0x9011", VA = "0x9011", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600415B RID: 16731 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600415C RID: 16732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CE8")]
		public ClanCombatPlayer EnemyGolem
		{
			[Token(Token = "0x600415B")]
			[Address(RVA = "0x9012", Offset = "0x9012", VA = "0x9012")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600415C")]
			[Address(RVA = "0x9013", Offset = "0x9013", VA = "0x9013")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600415D RID: 16733 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x17000CE9")]
		public bool JoinAvail
		{
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x9014", Offset = "0x9014", VA = "0x9014")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600415F RID: 16735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEA")]
		public BackTime GlobalTimeout
		{
			[Token(Token = "0x600415E")]
			[Address(RVA = "0x9015", Offset = "0x9015", VA = "0x9015")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600415F")]
			[Address(RVA = "0x9016", Offset = "0x9016", VA = "0x9016")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004160")]
		[Address(RVA = "0x9017", Offset = "0x9017", VA = "0x9017", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Combat_Model_ClanCombatModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5778b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatPlayer___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_CombatPlayer__TypeInfo);
		    DAT_ram_00a5778b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_CombatPlayer__TypeInfo);
		  *(undefined4 *)(param1 + 0x6c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_CombatPlayer__TypeInfo);
		  *(undefined4 *)(param1 + 0x70) = uVar1;
		  uVar1 = Mono_Security_ASN1Convert__ToOid(Gameplay_Combat_Model_CombatPlayer___TypeInfo,2);
		  *(undefined4 *)(param1 + 0x74) = uVar1;
		  Gameplay_Combat_TeamCombat_TeamCombatEvents___ctor(param1,param2,param5,param6,param7,0);
		  *(undefined4 *)(param1 + 0x68) = param4;
		  *(undefined4 *)(param1 + 0x5c) = param3;
		  return;
		}
		*/

		}

		// Token: 0x06004161 RID: 16737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004161")]
		[Address(RVA = "0x9018", Offset = "0x9018", VA = "0x9018")]
		public ClanCombatModel(CombatDependencies dependencies, uint jointRequirementId, RequirementsManager requirementsManager, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = 0x6c;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != param2) {
		    iVar1 = 0x70;
		  }
		  return *(undefined4 *)(param1 + iVar1);
		}
		*/

		}

		// Token: 0x06004162 RID: 16738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004162")]
		[Address(RVA = "0x9019", Offset = "0x9019", VA = "0x9019")]
		private LinkedList<CombatPlayer> GetPlayerList(uint userSide)
		{
		/* --- GHIDRA: GetPlayerList ---
		int * Gameplay_Clans_Combat_Model_ClanCombatModel__GetPlayerList
		                (int param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5,
		                undefined4 param6)
		
		{
		  uint uVar1;
		  int *param1_00;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int iVar9;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a5778c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5778c = '\x01';
		  }
		  piVar2 = (int *)Gameplay_Combat_Model_CombatModel__TryGetEventSpell
		                            (param1,param2,param3,param4,param5,0);
		  if (piVar2 != (int *)0x0) {
		    if (((uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*piVar2 + 0xb8)) &&
		       (param1_00 = piVar2,
		       *(int *)(*(int *)(*piVar2 + 100) +
		                (uint)*(byte *)(Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo + 0xb8) * 4 +
		               -4) != Gameplay_Clans_Combat_Model_ClanCombatPlayer_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  if ((*(int *)(param1_00[2] + 0x10) == 4) &&
		     (*(int *)(param1_00[2] + 0x14) != *(int *)(*(int *)(param1 + 0xc) + 0x2c))) {
		    *(int **)(param1 + 0x78) = param1_00;
		  }
		  lVar5 = Core_Data_UserData__get_UserId(param1_00,0);
		  lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  *(bool *)((int)param1_00 + 0x65) = lVar5 == lVar6;
		  iVar7 = param1_00[5];
		  if (*(int *)(iVar7 + 0x68) == 0) {
		    uVar8 = *(undefined4 *)(param5 + 0x2c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0x178);
		          goto code_r0x80dd8b71;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd8b71:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    uVar8 = func_ii_7325(uVar8,uVar4,0);
		    *(undefined4 *)(iVar7 + 0x68) = uVar8;
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004163")]
		[Address(RVA = "0x901A", Offset = "0x901A", VA = "0x901A", Slot = "9")]
		protected override CombatPlayer CreatePlayer(ICombatPlayerFactory playerFactory, ICombatSpellDataFactory spellFactory, IUserCache userCache, PlayerInfo playerInfo)
		{
		/* --- GHIDRA: CreatePlayer ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__CreatePlayer(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5778d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__AddLast__);
		    DAT_ram_00a5778d = '\x01';
		  }
		  param2_00 = Gameplay_Combat_Model_CombatModel__GetSpellsEnabled(param1,param2,0);
		  iVar1 = 0x6c;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != *(int *)(param2 + 0x14)) {
		    iVar1 = 0x70;
		  }
		  System_Collections_Generic_LinkedList_object____ctor
		            (*(undefined4 *)(param1 + iVar1),param2_00,
		             Method_System_Collections_Generic_LinkedList_CombatPlayer__AddLast__);
		  return param2_00;
		}
		*/

			return null;
		}

		// Token: 0x06004164 RID: 16740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004164")]
		[Address(RVA = "0x901B", Offset = "0x901B", VA = "0x901B", Slot = "15")]
		public override CombatPlayer AddPlayer(PlayerInfo playerInfo)
		{
		/* --- GHIDRA: AddPlayer ---
		int Gameplay_Clans_Combat_Model_ClanCombatModel__AddPlayer
		              (int param1,undefined8 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5778e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__Remove__);
		    DAT_ram_00a5778e = '\x01';
		  }
		  iVar1 = Gameplay_Combat_Model_CombatModel__AddPlayer(param1,param2,param3,0);
		  if (iVar1 != 0) {
		    iVar2 = 0x6c;
		    if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != *(int *)(*(int *)(*param3 + 8) + 0x14)) {
		      iVar2 = 0x70;
		    }
		    System_Net_WebConnection__StartOperation
		              (*(undefined4 *)(param1 + iVar2),*param3,
		               Method_System_Collections_Generic_LinkedList_CombatPlayer__Remove__);
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06004165 RID: 16741 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x6004165")]
		[Address(RVA = "0x901C", Offset = "0x901C", VA = "0x901C", Slot = "16")]
		public override bool RemovePlayer(ulong userId, out CombatPlayer player)
		{
		/* --- GHIDRA: RemovePlayer ---
		void Gameplay_Clans_Combat_Model_ClanCombatModel__RemovePlayer
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5778f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_CombatPlayer__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__AddLast__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__RemoveFirst__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__get_First__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatPlayer__TypeInfo);
		    DAT_ram_00a5778f = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_CombatPlayer__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_CombatPlayer___ctor__);
		  *param2 = iVar1;
		  iVar1 = *(int *)(param1 + 0x6c);
		  if (1 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = *(int *)(iVar1 + 8);
		    System_Collections_Generic_LinkedList_object___OnDeserialization
		              (iVar1,Method_System_Collections_Generic_LinkedList_CombatPlayer__RemoveFirst__);
		    System_Collections_Generic_LinkedList_object___Remove
		              (*(undefined4 *)(param1 + 0x6c),iVar2,
		               Method_System_Collections_Generic_LinkedList_CombatPlayer__AddLast__);
		    iVar1 = Method_System_Collections_Generic_List_CombatPlayer__Add__;
		    uVar3 = *(undefined4 *)(iVar2 + 0x14);
		    iVar2 = *param2;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar4 = *(uint *)(iVar2 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar4 * 4 + 0x10) = uVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar1 = *(int *)(param1 + 0x70);
		  if (1 < *(int *)(iVar1 + 0xc)) {
		    iVar2 = *(int *)(iVar1 + 8);
		    System_Collections_Generic_LinkedList_object___OnDeserialization
		              (iVar1,Method_System_Collections_Generic_LinkedList_CombatPlayer__RemoveFirst__);
		    System_Collections_Generic_LinkedList_object___Remove
		              (*(undefined4 *)(param1 + 0x70),iVar2,
		               Method_System_Collections_Generic_LinkedList_CombatPlayer__AddLast__);
		    iVar1 = Method_System_Collections_Generic_List_CombatPlayer__Add__;
		    uVar3 = *(undefined4 *)(iVar2 + 0x14);
		    iVar2 = *param2;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar4 = *(uint *)(iVar2 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar4 * 4 + 0x10) = uVar3;
		      return;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar2,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004166")]
		[Address(RVA = "0x901D", Offset = "0x901D", VA = "0x901D")]
		public void MovePlayers(out List<CombatPlayer> downPlayers)
		{
		/* --- GHIDRA: MovePlayers ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__MovePlayers(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57790 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__get_Count__);
		    DAT_ram_00a57790 = '\x01';
		  }
		  iVar1 = 0x6c;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != *(int *)(*(int *)(param2 + 8) + 0x14)) {
		    iVar1 = 0x70;
		  }
		  return *(undefined4 *)(*(int *)(param1 + iVar1) + 0xc);
		}
		*/

		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x6004167")]
		[Address(RVA = "0x901E", Offset = "0x901E", VA = "0x901E")]
		public int GetPlayerCount(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayerCount ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__GetPlayerCount
		          (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57791 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_CombatPlayer__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__get_First__);
		    DAT_ram_00a57791 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x74);
		  if (piVar3 == (int *)0x0) {
		    *param2 = 0;
		    return 0;
		  }
		  iVar4 = *(int *)(param1 + 0x6c);
		  if ((((iVar4 == 0) || (*(int *)(param1 + 0x70) == 0)) || (*(int *)(iVar4 + 0xc) == 0)) ||
		     (*(int *)(*(int *)(param1 + 0x70) + 0xc) == 0)) {
		    *param2 = 0;
		    return 0;
		  }
		  iVar4 = *(int *)(*(int *)(iVar4 + 8) + 0x14);
		  if ((iVar4 != 0) && (iVar1 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar4;
		  piVar3 = *(int **)(param1 + 0x74);
		  iVar4 = *(int *)(*(int *)(*(int *)(param1 + 0x70) + 8) + 0x14);
		  if ((iVar4 != 0) && (iVar1 = func_ii_1082(iVar4,*(undefined4 *)(*piVar3 + 0x20)), iVar1 == 0)) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[5] = iVar4;
		  *param2 = *(undefined4 *)(param1 + 0x74);
		  return 1;
		}
		*/

			return 0;
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x6004168")]
		[Address(RVA = "0x901F", Offset = "0x901F", VA = "0x901F")]
		public bool TryGetCurrentPlayers(out CombatPlayer[] players)
		{
		/* --- GHIDRA: TryGetCurrentPlayers ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__TryGetCurrentPlayers
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57792 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CombatPlayer___);
		    DAT_ram_00a57792 = '\x01';
		  }
		  iVar2 = 0x6c;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != param2) {
		    iVar2 = 0x70;
		  }
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (*(undefined4 *)(param1 + iVar2),
		                     Method_System_Linq_Enumerable_ToList_CombatPlayer___);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004169")]
		[Address(RVA = "0x9020", Offset = "0x9020", VA = "0x9020", Slot = "17")]
		public override List<CombatPlayer> GetTeamPlayersContains(uint userSide)
		{
		/* --- GHIDRA: GetTeamPlayersContains ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__GetTeamPlayersContains
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57793 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CombatPlayer___);
		    DAT_ram_00a57793 = '\x01';
		  }
		  iVar2 = 0x70;
		  if (*(int *)(*(int *)(param1 + 0xc) + 0x2c) != param2) {
		    iVar2 = 0x6c;
		  }
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (*(undefined4 *)(param1 + iVar2),
		                     Method_System_Linq_Enumerable_ToList_CombatPlayer___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416A")]
		[Address(RVA = "0x9021", Offset = "0x9021", VA = "0x9021", Slot = "18")]
		public override List<CombatPlayer> GetTeamPlayersNotContains(uint userSide)
		{
		/* --- GHIDRA: GetTeamPlayersNotContains ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__GetTeamPlayersNotContains(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  int local_4;
		  
		  if (DAT_ram_00a57794 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_ClanWars_IClanWars_TypeInfo);
		    DAT_ram_00a57794 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x60);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Clans_ClanWars_IClanWars_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dd906b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Gameplay_Clans_ClanWars_IClanWars_TypeInfo,0);
		code_r0x80dd906b:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,&local_4,puVar2[1]);
		  if ((iVar3 == 0) || (*(int *)(*(int *)(local_4 + 0xc) + 0x1c) != 2)) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = Utils_MoneyUtils__CalculateResource(0);
		  }
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416B")]
		[Address(RVA = "0x9022", Offset = "0x9022", VA = "0x9022", Slot = "12")]
		public override ResourceSet GetNextCombatCost()
		{
		/* --- GHIDRA: GetNextCombatCost ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__GetNextCombatCost
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57795 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatEventData_TypeInfo);
		    DAT_ram_00a57795 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Clans_Combat_Model_ClanCombatEventData_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,param2,0);
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600416C")]
		[Address(RVA = "0x9023", Offset = "0x9023", VA = "0x9023", Slot = "13")]
		protected override CombatEventData CreateCombatEventData(CombatEventDic dict)
		{
		/* --- GHIDRA: CreateCombatEventData ---
		void Gameplay_Clans_Combat_Model_ClanCombatModel__CreateCombatEventData
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57796 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_EffectData__TypeInfo);
		    DAT_ram_00a57796 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_Model_TeamCombatPlayer__set_IsMyPlayer(param1,param2,param3,param4,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_EffectData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_EffectData___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0x5C")]
		public readonly uint JointRequirementId;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x6C")]
		private LinkedList<CombatPlayer> _userSideQueue;

		// Token: 0x04002441 RID: 9281
		[Token(Token = "0x4002441")]
		[FieldOffset(Offset = "0x70")]
		private LinkedList<CombatPlayer> _enemiesQueue;

		// Token: 0x04002442 RID: 9282
		[Token(Token = "0x4002442")]
		[FieldOffset(Offset = "0x74")]
		private CombatPlayer[] _currentPlayers;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_RequirementsManager ---
		undefined4
		Gameplay_Clans_Combat_Model_ClanCombatModel__set_RequirementsManager(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  longlong lVar5;
		  longlong lVar6;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5778a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_CombatPlayer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_CombatPlayer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_Enumerator_CombatPlayer__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_CombatPlayer__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_CombatPlayer__get_First__);
		    DAT_ram_00a5778a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  if (*(char *)(param1 + 100) == '\0') {
		    func_ii_16538(&local_18,*(int *)(param1 + 0x6c),
		                  Method_System_Collections_Generic_LinkedList_CombatPlayer__GetEnumerator__);
		    local_20 = 0;
		    local_1c = &local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x355,&local_18,
		                         Method_System_Collections_Generic_LinkedList_Enumerator_CombatPlayer__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dd88cb;
		      }
		      if (iVar2 == 0) {
		        uVar3 = 0;
		        break;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = local_10._4_4_;
		      lVar5 = unnamed_function_184054
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,
		                         *(undefined4 *)(param1 + 8),0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dd88cb:
		        iVar1 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 == iVar2) {
		          piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		          iVar2 = *piVar4;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		            if (iVar2 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return 0;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar3 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x358,&local_20);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      DAT_ram_009d3e38 = 0;
		      lVar6 = unnamed_function_184054
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x357,uVar3,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dd88cb;
		      }
		    } while (lVar5 != lVar6);
		    DAT_ram_009d3e38 = 0;
		  }
		  else {
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x6c) + 8) + 0x14);
		  }
		  return uVar3;
		}
		*/


		/* --- GHIDRA: set_EnemyGolem ---
		undefined4 Gameplay_Clans_Combat_Model_ClanCombatModel__set_EnemyGolem(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                    (*(undefined4 *)(param1 + 0x68),*(undefined4 *)(param1 + 0x5c),
		                     *(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_GlobalTimeout ---
		void Gameplay_Clans_Combat_Model_ClanCombatModel__set_GlobalTimeout(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x7c) = 0;
		  *(undefined4 *)(param1 + 0x60) = 0;
		  *(undefined8 *)(param1 + 0x68) = 0;
		  *(undefined8 *)(param1 + 0x70) = 0;
		  Gameplay_Combat_Model_CombatModel__GetState(param1,0);
		  return;
		}
		*/

}
