using System;
using Il2CppDummyDll;
using Protocol.SmallGames;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	public class SingleRewardView : MonoBehaviourWithStates<SingleRewardView.State>
	{
		// Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0x7113", Offset = "0x7113", VA = "0x7113", Slot = "5")]
		public virtual void Init(ProtoRegisterVisitAns.Types.DailyRewards data, string title, SingleRewardView.State state)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_DailyRewards_SingleRewardView__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a582a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SingleRewardView_State___ctor__)
		    ;
		    DAT_ram_00a582a8 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SingleRewardView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0x7114", Offset = "0x7114", VA = "0x7114")]
		public SingleRewardView()
		{
		}

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected RewardsRender _artikulRender;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x04001162 RID: 4450
		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected Sprite _completedBg;

		// Token: 0x04001163 RID: 4451
		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Image _bg;

		// Token: 0x02000534 RID: 1332
		[Token(Token = "0x2000534")]
		public enum State
		{
			// Token: 0x04001165 RID: 4453
			[Token(Token = "0x4001165")]
			UNKNOWN,
			// Token: 0x04001166 RID: 4454
			[Token(Token = "0x4001166")]
			RECEIVED,
			// Token: 0x04001167 RID: 4455
			[Token(Token = "0x4001167")]
			RECEIVED_EXTRA = 4,
			// Token: 0x04001168 RID: 4456
			[Token(Token = "0x4001168")]
			PENDING = 2,
			// Token: 0x04001169 RID: 4457
			[Token(Token = "0x4001169")]
			UNRECEIVED
		}
	}
}
