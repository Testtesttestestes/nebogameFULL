using System;
using System.Runtime.CompilerServices;
using Gameplay.BlitzTournament.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Tournaments;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	[TupleElementNames(new string[]
	{
		"fighter1",
		"fighter2"
	})]
	public class TournamentBattleInfoListElement : BattleInfoListElementBase<TournamentPlayerBattleView, ValueTuple<Fighter, Fighter>>
	{
		// Token: 0x14000135 RID: 309
		// (add) Token: 0x06001C15 RID: 7189 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001C16 RID: 7190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000135")]
		public event Action<UserInfo> WatchButtonClickedEvent
		{
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x6D94", Offset = "0x6D94", VA = "0x6D94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x6D95", Offset = "0x6D95", VA = "0x6D95")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004EF")]
		public TournamentPlayerBattleView Player1
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x6D96", Offset = "0x6D96", VA = "0x6D96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001C18 RID: 7192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004F0")]
		public TournamentPlayerBattleView Player2
		{
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x6D97", Offset = "0x6D97", VA = "0x6D97")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x6D98", Offset = "0x6D98", VA = "0x6D98", Slot = "6")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__Awake(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___OnDestroy__
		              );
		    DAT_ram_00a584f0 = '\x01';
		  }
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4),0);
		  Gameplay_BlitzTournament_View_BattleInfoListElementBase_object__ValueTuple_object__object____Awake
		            (param1,
		             Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___OnDestroy__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x6D99", Offset = "0x6D99", VA = "0x6D99", Slot = "7")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),
		               *(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x3c) + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x6D9A", Offset = "0x6D9A", VA = "0x6D9A")]
		private void WatchButtonClickedEventHandler()
		{
		/* --- GHIDRA: WatchButtonClickedEventHandler ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__WatchButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 == 3),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 != 3),0);
		  return;
		}
		*/

		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x6D9B", Offset = "0x6D9B", VA = "0x6D9B")]
		public void DetermineAction(TournamentStates state)
		{
		/* --- GHIDRA: DetermineAction ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__DetermineAction
		               (int param1,undefined4 param2)
		
		{
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(param1 + 0x1c),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x6D9C", Offset = "0x6D9C", VA = "0x6D9C")]
		public void DisableWatchButton()
		{
		/* --- GHIDRA: DisableWatchButton ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__DisableWatchButton
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  Gameplay_Tournaments_View_TournamentPlayerBattleView__get__totalHealth
		            (*(undefined4 *)(param1 + 0x10),*param2,param2);
		  Gameplay_Tournaments_View_TournamentPlayerBattleView__get__totalHealth
		            (*(undefined4 *)(param1 + 0x14),param2[1],param2);
		  return;
		}
		*/

		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x6D9D", Offset = "0x6D9D", VA = "0x6D9D", Slot = "5")]
		public override void Init([TupleElementNames(new string[]
		{
			"fighter1",
			"fighter2"
		})] ValueTuple<Fighter, Fighter> info)
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x6D9E", Offset = "0x6D9E", VA = "0x6D9E", Slot = "4")]
		public override bool TryGetPlayerView(ulong userId, out TournamentPlayerBattleView playerView)
		{
		/* --- GHIDRA: TryGetPlayerView ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__TryGetPlayerView
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter____ctor__
		              );
		    DAT_ram_00a584f1 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter____ctor__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x6D9F", Offset = "0x6D9F", VA = "0x6D9F")]
		public TournamentBattleInfoListElement()
		{
		}

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _swordsImage;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_WatchButtonClickedEvent ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__add_WatchButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a584ee == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_UserInfo__TypeInfo);
		    DAT_ram_00a584ee = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_UserInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_UserInfo__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_Player2 ---
		void Gameplay_Tournaments_View_TournamentBattleInfoListElement__get_Player2
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a584ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___Awake__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_View_TournamentBattleInfoListElement_WatchButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a584ef = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Tournaments_View_TournamentBattleInfoListElement_WatchButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  Gameplay_BlitzTournament_View_BattleInfoListElementBase_object__ValueTuple_object__object_____ctor
		            (param1,
		             Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_TournamentPlayerBattleView__ValueTuple_Fighter__Fighter___Awake__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: Init ---
		uint Gameplay_Tournaments_View_TournamentBattleInfoListElement__Init
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  
		  uVar1 = 1;
		  iVar2 = *(int *)(param1 + 0x10);
		  if (param2 != *(longlong *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0xc) + 0x10)) {
		    iVar2 = *(int *)(param1 + 0x14);
		    uVar1 = (uint)(*(longlong *)(*(int *)(*(int *)(iVar2 + 0x3c) + 0xc) + 0x10) == param2);
		    if (uVar1 == 0) {
		      iVar2 = 0;
		    }
		  }
		  *param3 = iVar2;
		  return uVar1;
		}
		*/

}
