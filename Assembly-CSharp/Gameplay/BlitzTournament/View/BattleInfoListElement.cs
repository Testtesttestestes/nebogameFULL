using System;
using Il2CppDummyDll;
using Protocol.BlitzTournaments;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BBF RID: 3007
	[Token(Token = "0x2000BBF")]
	public class BattleInfoListElement : BattleInfoListElementBase<PlayerBattleView, BattleInfo>
	{
		// Token: 0x060049C6 RID: 18886 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x60049C6")]
		[Address(RVA = "0x9838", Offset = "0x9838", VA = "0x9838", Slot = "4")]
		public override bool TryGetPlayerView(ulong userId, out PlayerBattleView playerView)
		{
		/* --- GHIDRA: TryGetPlayerView ---
		void Gameplay_BlitzTournament_View_BattleInfoListElement__TryGetPlayerView
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60892 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_FighterInfo__get_Item__);
		    DAT_ram_00a60892 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param2 + 0xc),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_FighterInfo__get_Item__);
		  Gameplay_BlitzTournament_View_PlayerBattleView__get__totalHealth(uVar2,uVar1,param2);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param2 + 0xc),1,
		                     Method_Google_Protobuf_Collections_RepeatedField_FighterInfo__get_Item__);
		  Gameplay_BlitzTournament_View_PlayerBattleView__get__totalHealth(uVar2,uVar1,param2);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060049C7 RID: 18887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C7")]
		[Address(RVA = "0x9839", Offset = "0x9839", VA = "0x9839", Slot = "5")]
		public override void Init(BattleInfo battleInfo)
		{
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C8")]
		[Address(RVA = "0x983A", Offset = "0x983A", VA = "0x983A", Slot = "8")]
		protected override void PlayerClickedEventHandler(PlayerBattleViewBase view)
		{
		/* --- GHIDRA: PlayerClickedEventHandler ---
		void Gameplay_BlitzTournament_View_BattleInfoListElement__PlayerClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60893 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_PlayerBattleView__BattleInfo___ctor__
		              );
		    DAT_ram_00a60893 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_BlitzTournament_View_BattleInfoListElementBase_PlayerBattleView__BattleInfo___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049C9")]
		[Address(RVA = "0x983B", Offset = "0x983B", VA = "0x983B")]
		public BattleInfoListElement()
		{
		}
	}
}
