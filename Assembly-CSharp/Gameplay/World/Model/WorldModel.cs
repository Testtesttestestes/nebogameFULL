using System;
using System.Runtime.CompilerServices;
using System.Text;
using Core.Data;
using Core.Data.User;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Isles.Axis;
using Gameplay.Isles.Base;
using Gameplay.Isles.Clan;
using Gameplay.Isles.User;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Consts;
using Utils.Timers;

namespace Gameplay.World.Model
{
	// Token: 0x0200036C RID: 876
	[Token(Token = "0x200036C")]
	public class WorldModel : AbstractModel
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		[CanBeNull]
		public IsleAnimationRequestVo LastSuccessIsleAnimationRequest
		{
			[Token(Token = "0x600144A")]
			[Address(RVA = "0x6618", Offset = "0x6618", VA = "0x6618")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600144B")]
			[Address(RVA = "0x6619", Offset = "0x6619", VA = "0x6619")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600144C")]
		[Address(RVA = "0x661A", Offset = "0x661A", VA = "0x661A")]
		public WorldModel(IGame game, IDictProvider dictProvider, IUserSettings userSettings, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_World_Model_WorldModel___ctor(int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  uint uVar2;
		  longlong lVar3;
		  
		  if (DAT_ram_00a58c8c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    DAT_ram_00a58c8c = '\x01';
		  }
		  if (*(int *)(param1 + 0x24) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    lVar3 = *(longlong *)(*(int *)(param1 + 0x24) + 0x18);
		    lVar1 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1 + 8),0);
		    uVar2 = (uint)(lVar3 == lVar1);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x17000351")]
		public bool IsAtHome
		{
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x661B", Offset = "0x661B", VA = "0x661B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00004F98 File Offset: 0x00003198
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000352")]
		public LocationTypes CurrentLocationType
		{
			[Token(Token = "0x600144E")]
			[Address(RVA = "0x661C", Offset = "0x661C", VA = "0x661C")]
			[CompilerGenerated]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
			[Token(Token = "0x600144F")]
			[Address(RVA = "0x661D", Offset = "0x661D", VA = "0x661D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6001450")]
		[Address(RVA = "0x661E", Offset = "0x661E", VA = "0x661E")]
		public ulong GetCurrentLocationId()
		{
			return 0UL;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		public UserIsle OwnUserIsle
		{
			[Token(Token = "0x6001451")]
			[Address(RVA = "0x661F", Offset = "0x661F", VA = "0x661F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x6620", Offset = "0x6620", VA = "0x6620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000354")]
		[CanBeNull]
		public UserIsle CurrentUserIsle
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x6621", Offset = "0x6621", VA = "0x6621")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x6622", Offset = "0x6622", VA = "0x6622")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000355")]
		[CanBeNull]
		public ClanIsle CurrentClanIsle
		{
			[Token(Token = "0x6001455")]
			[Address(RVA = "0x6623", Offset = "0x6623", VA = "0x6623")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001456")]
			[Address(RVA = "0x6624", Offset = "0x6624", VA = "0x6624")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		[CanBeNull]
		public AxisIsle CurrentAxisIsle
		{
			[Token(Token = "0x6001457")]
			[Address(RVA = "0x6625", Offset = "0x6625", VA = "0x6625")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001458")]
			[Address(RVA = "0x6626", Offset = "0x6626", VA = "0x6626")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public IsleHeap<UserIsle> UserIsleHeap
		{
			[Token(Token = "0x6001459")]
			[Address(RVA = "0x6627", Offset = "0x6627", VA = "0x6627")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600145A")]
			[Address(RVA = "0x6628", Offset = "0x6628", VA = "0x6628")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000358")]
		public IsleHeap<ClanIsle> ClanIsleHeap
		{
			[Token(Token = "0x600145B")]
			[Address(RVA = "0x6629", Offset = "0x6629", VA = "0x6629")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600145C")]
			[Address(RVA = "0x662A", Offset = "0x662A", VA = "0x662A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x17000359")]
		public int CacheTtl
		{
			[Token(Token = "0x600145D")]
			[Address(RVA = "0x1CA0", Offset = "0x1CA0", VA = "0x1CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x1700035A")]
		public double BuildingCancelRecoilCoeff
		{
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x662B", Offset = "0x662B", VA = "0x662B")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035B")]
		public TimerTracker AnimationsCooldown
		{
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x662C", Offset = "0x662C", VA = "0x662C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x662D", Offset = "0x662D", VA = "0x662D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035C")]
		public bool IsMovingOnWorldLevel
		{
			[Token(Token = "0x6001461")]
			[Address(RVA = "0x662E", Offset = "0x662E", VA = "0x662E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001462")]
			[Address(RVA = "0x662F", Offset = "0x662F", VA = "0x662F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x6630", Offset = "0x6630", VA = "0x6630")]
		[CanBeNull]
		public UserIsle GetUserIsle(ulong userId)
		{
		/* --- GHIDRA: GetUserIsle ---
		undefined4
		Gameplay_World_Model_WorldModel__GetUserIsle(int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c91 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__GetIsle__);
		    DAT_ram_00a58c91 = '\x01';
		  }
		  uVar1 = Gameplay_World_Model_IsleHeap_object___Dispose
		                    (*(undefined4 *)(param1 + 0x34),param2,
		                     Method_Gameplay_World_Model_IsleHeap_ClanIsle__GetIsle__);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x6631", Offset = "0x6631", VA = "0x6631")]
		[CanBeNull]
		public ClanIsle GetClanIsle(ulong clanId)
		{
		/* --- GHIDRA: GetClanIsle ---
		int Gameplay_World_Model_WorldModel__GetClanIsle
		              (int param1,int param2,longlong param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int local_4;
		  
		  if (DAT_ram_00a58c92 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_LocationTypes_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17959);
		    DAT_ram_00a58c92 = '\x01';
		  }
		  if (param2 == 1) {
		    if (DAT_ram_00a58c90 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		                );
		      Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		      DAT_ram_00a58c90 = '\x01';
		    }
		    iVar2 = *(int *)(param1 + 0x20);
		    if ((iVar2 == 0) || (*(longlong *)(iVar2 + 0x18) != param3)) {
		      iVar2 = Gameplay_World_Model_IsleHeap_object___Dispose
		                        (*(undefined4 *)(param1 + 0x30),param3,
		                         Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    }
		  }
		  else if (param2 == 2) {
		    if (DAT_ram_00a58c91 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle__GetIsle__);
		      DAT_ram_00a58c91 = '\x01';
		    }
		    iVar2 = Gameplay_World_Model_IsleHeap_object___Dispose
		                      (*(undefined4 *)(param1 + 0x34),param3,
		                       Method_Gameplay_World_Model_IsleHeap_ClanIsle__GetIsle__);
		  }
		  else {
		    iVar2 = 0;
		    local_4 = param2;
		    uVar1 = func_ii_1081(Protocol_Consts_LocationTypes_TypeInfo,&local_4);
		    uVar1 = func_ii_4419(StringLiteral_17959,uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar1,0);
		  }
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x6632", Offset = "0x6632", VA = "0x6632")]
		[CanBeNull]
		public IIsle GetIsleByTypeAndId(LocationTypes type, ulong id)
		{
		/* --- GHIDRA: GetIsleByTypeAndId ---
		int Gameplay_World_Model_WorldModel__GetIsleByTypeAndId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x24);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(param1 + 0x28);
		  }
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x6633", Offset = "0x6633", VA = "0x6633")]
		[CanBeNull]
		public IIsle GetCurrentIsle()
		{
		/* --- GHIDRA: GetCurrentIsle ---
		longlong Gameplay_World_Model_WorldModel__GetCurrentIsle(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  longlong lVar5;
		  uint uVar6;
		  int local_8;
		  int local_4;
		  
		  lVar5 = 0;
		  if (DAT_ram_00a58c93 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22853);
		    DAT_ram_00a58c93 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f946db;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f946db:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_22853,0);
		  iVar4 = Gameplay_Antiq_Model_AntiqModel__SetArtifacts
		                    (7,*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 8),&local_4,0);
		  if ((iVar4 != 0) && (0 < *(longlong *)(local_4 + 0x10))) {
		    piVar3 = (int *)Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(param1 + 8),0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                      (piVar3,uVar2,&local_8,*(undefined4 *)(*piVar3 + 0x104));
		    if (iVar4 != 0) {
		      lVar5 = *(longlong *)(local_4 + 0x10) - *(longlong *)(local_8 + 0x10);
		    }
		  }
		  return lVar5;
		}
		*/

			return null;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x6634", Offset = "0x6634", VA = "0x6634")]
		public long GetLeftOverCountOfIsleAnimationWhitOutCoolDown()
		{
		/* --- GHIDRA: GetLeftOverCountOfIsleAnimationWhitOutCoolDown ---
		void Gameplay_World_Model_WorldModel__GetLeftOverCountOfIsleAnimationWhitOutCoolDown
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined1 *)(param1 + 0x10) = (undefined1)param3;
		  *(undefined8 *)(param1 + 8) = param2;
		  return;
		}
		*/

			return 0L;
		}

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x10")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x14")]
		public readonly IUserSettings UserSettings;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0x38")]
		private int _cacheTtl;

		// Token: 0x0200036D RID: 877
		[Token(Token = "0x200036D")]
		[NullableContext(1)]
		[Nullable(0)]
		public class WorldUserIsleRequestVo : IEquatable<WorldModel.WorldUserIsleRequestVo>
		{
			// Token: 0x06001468 RID: 5224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001468")]
			[Address(RVA = "0x6635", Offset = "0x6635", VA = "0x6635")]
			public WorldUserIsleRequestVo(ulong UserId, bool GoOnSuccess)
			{
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06001469 RID: 5225 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700035D")]
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[Token(Token = "0x6001469")]
				[Address(RVA = "0x6636", Offset = "0x6636", VA = "0x6636", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x0600146A RID: 5226 RVA: 0x00005028 File Offset: 0x00003228
			// (set) Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700035E")]
			public ulong UserId
			{
				[Token(Token = "0x600146A")]
				[Address(RVA = "0x6637", Offset = "0x6637", VA = "0x6637")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x600146B")]
				[Address(RVA = "0x6638", Offset = "0x6638", VA = "0x6638")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x0600146C RID: 5228 RVA: 0x00005040 File Offset: 0x00003240
			// (set) Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700035F")]
			public bool GoOnSuccess
			{
				[Token(Token = "0x600146C")]
				[Address(RVA = "0x6639", Offset = "0x6639", VA = "0x6639")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600146D")]
				[Address(RVA = "0x663A", Offset = "0x663A", VA = "0x663A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600146E RID: 5230 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x663B", Offset = "0x663B", VA = "0x663B", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600146F RID: 5231 RVA: 0x00005058 File Offset: 0x00003258
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x663C", Offset = "0x663C", VA = "0x663C", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				return default(bool);
			}

			// Token: 0x06001470 RID: 5232 RVA: 0x00005070 File Offset: 0x00003270
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x663D", Offset = "0x663D", VA = "0x663D")]
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator !=(WorldModel.WorldUserIsleRequestVo left, WorldModel.WorldUserIsleRequestVo right)
			{
				return default(bool);
			}

			// Token: 0x06001471 RID: 5233 RVA: 0x00005088 File Offset: 0x00003288
			[Token(Token = "0x6001471")]
			[Address(RVA = "0x663E", Offset = "0x663E", VA = "0x663E")]
			[NullableContext(2)]
			[CompilerGenerated]
			public static bool operator ==(WorldModel.WorldUserIsleRequestVo left, WorldModel.WorldUserIsleRequestVo right)
			{
				return default(bool);
			}

			// Token: 0x06001472 RID: 5234 RVA: 0x000050A0 File Offset: 0x000032A0
			[Token(Token = "0x6001472")]
			[Address(RVA = "0x663F", Offset = "0x663F", VA = "0x663F", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06001473 RID: 5235 RVA: 0x000050B8 File Offset: 0x000032B8
			[Token(Token = "0x6001473")]
			[Address(RVA = "0x6640", Offset = "0x6640", VA = "0x6640", Slot = "0")]
			[NullableContext(2)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06001474 RID: 5236 RVA: 0x000050D0 File Offset: 0x000032D0
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x6641", Offset = "0x6641", VA = "0x6641", Slot = "7")]
			[NullableContext(2)]
			[CompilerGenerated]
			public virtual bool Equals(WorldModel.WorldUserIsleRequestVo other)
			{
				return default(bool);
			}

			// Token: 0x06001476 RID: 5238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001476")]
			[Address(RVA = "0x6643", Offset = "0x6643", VA = "0x6643")]
			[CompilerGenerated]
			protected WorldUserIsleRequestVo(WorldModel.WorldUserIsleRequestVo original)
			{
			}

			// Token: 0x06001477 RID: 5239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001477")]
			[Address(RVA = "0x6644", Offset = "0x6644", VA = "0x6644")]
			[CompilerGenerated]
			public void Deconstruct(out ulong UserId, out bool GoOnSuccess)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_LastSuccessIsleAnimationRequest ---
		void Gameplay_World_Model_WorldModel__set_LastSuccessIsleAnimationRequest
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c8b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_ClanIsle___ctor__);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleHeap_ClanIsle__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleHeap_UserIsle__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_TimerTracker_TypeInfo);
		    DAT_ram_00a58c8b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_Timers_TimerTracker_TypeInfo);
		  Utils_Timers_TimerTracker__remove_TimerExpiredEvent(uVar1,0);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param5,0);
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  uVar1 = unnamed_function_1417(Gameplay_World_Model_IsleHeap_UserIsle__TypeInfo);
		  UnityEngine_UIElements_UQuery_IsOfType_object___Predicate
		            (uVar1,Method_Gameplay_World_Model_IsleHeap_UserIsle___ctor__);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  uVar1 = unnamed_function_1417(Gameplay_World_Model_IsleHeap_ClanIsle__TypeInfo);
		  UnityEngine_UIElements_UQuery_IsOfType_object___Predicate
		            (uVar1,Method_Gameplay_World_Model_IsleHeap_ClanIsle___ctor__);
		  *(undefined4 *)(param1 + 0x34) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentLocationType ---
		undefined8 Gameplay_World_Model_WorldModel__set_CurrentLocationType(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58c8d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_AxisIsleEvents__AxisIsleModel__AxisIsleController__AxisIsle_EmptyEnum__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    DAT_ram_00a58c8d = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x24);
		  if (((iVar3 == 0) && (iVar3 = *(int *)(param1 + 0x28), iVar3 == 0)) &&
		     (iVar3 = *(int *)(param1 + 0x2c), iVar3 == 0)) {
		    uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_17862);
		    System_String__Concat(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232(&Method_Gameplay_World_Model_WorldModel_GetCurrentLocationId__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return *(undefined8 *)(iVar3 + 0x18);
		}
		*/


		/* --- GHIDRA: set_ClanIsleHeap ---
		double Gameplay_World_Model_WorldModel__set_ClanIsleHeap(int param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  double dVar3;
		  int *param1_00;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a58c8f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20789);
		    DAT_ram_00a58c8f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f9442f;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f9442f:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  dVar3 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar2,StringLiteral_20789,0);
		  return dVar3;
		}
		*/


		/* --- GHIDRA: get_CacheTtl ---
		void Gameplay_World_Model_WorldModel__get_CacheTtl
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a58d10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    DAT_ram_00a58d10 = '\x01';
		  }
		  Gameplay_Isles_User_UserIsle__ToString(param1,param2,param3,param5,param1);
		  Gameplay_World_Model_ClanData__Create(*(undefined4 *)(param1 + 0x14),param4,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_IsMovingOnWorldLevel ---
		int Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel
		              (int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c90 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		    DAT_ram_00a58c90 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if ((iVar1 == 0) || (*(longlong *)(iVar1 + 0x18) != param2)) {
		    iVar1 = Gameplay_World_Model_IsleHeap_object___Dispose
		                      (*(undefined4 *)(param1 + 0x30),param2,
		                       Method_Gameplay_World_Model_IsleHeap_UserIsle__GetIsle__);
		  }
		  return iVar1;
		}
		*/

}
