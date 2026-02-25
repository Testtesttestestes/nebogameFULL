using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2000ACE")]
	public class WarStatusView : MonoBehaviourWithStates<WarStatusView.State>
	{
		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D22")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x60042A0")]
			[Address(RVA = "0x9154", Offset = "0x9154", VA = "0x9154")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060042A1 RID: 17057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D23")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x60042A1")]
			[Address(RVA = "0x9155", Offset = "0x9155", VA = "0x9155")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D24")]
		public TextMeshProUGUI StatusAnnotation
		{
			[Token(Token = "0x60042A2")]
			[Address(RVA = "0x9156", Offset = "0x9156", VA = "0x9156")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060042A3 RID: 17059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D25")]
		public Button ActionButton
		{
			[Token(Token = "0x60042A3")]
			[Address(RVA = "0x9157", Offset = "0x9157", VA = "0x9157")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D26")]
		public Button CombatButton
		{
			[Token(Token = "0x60042A4")]
			[Address(RVA = "0x9158", Offset = "0x9158", VA = "0x9158")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060042A5 RID: 17061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D27")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x60042A5")]
			[Address(RVA = "0x9159", Offset = "0x9159", VA = "0x9159")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D28")]
		public TextMeshProUGUI BottomAnnotation
		{
			[Token(Token = "0x60042A6")]
			[Address(RVA = "0x915A", Offset = "0x915A", VA = "0x915A")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A7")]
		[Address(RVA = "0x915B", Offset = "0x915B", VA = "0x915B")]
		public void SetStatusKey(string localizationKey)
		{
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A8")]
		[Address(RVA = "0x915C", Offset = "0x915C", VA = "0x915C")]
		public void SetActionButtonKey(string localizationKey)
		{
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x915D", Offset = "0x915D", VA = "0x915D")]
		public void SetDefendersAndAttackers(uint defenders, uint attackers)
		{
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x915E", Offset = "0x915E", VA = "0x915E")]
		public WarStatusView()
		{
		}

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _statusTitle;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _statusAnnotation;

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _actionButton;

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _combatButton;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private RequirementsView _requirements;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _defenders;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _attackers;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _bottomAnnotation;

		// Token: 0x02000ACF RID: 2767
		[Token(Token = "0x2000ACF")]
		public enum State
		{
			// Token: 0x040024D5 RID: 9429
			[Token(Token = "0x40024D5")]
			UNKNOWN_STATE,
			// Token: 0x040024D6 RID: 9430
			[Token(Token = "0x40024D6")]
			ALL_ENABLED,
			// Token: 0x040024D7 RID: 9431
			[Token(Token = "0x40024D7")]
			ADD_BOTTOM_ANNOTATION,
			// Token: 0x040024D8 RID: 9432
			[Token(Token = "0x40024D8")]
			COMBAT,
			// Token: 0x040024D9 RID: 9433
			[Token(Token = "0x40024D9")]
			HIDE_ALL
		}
	}
}
