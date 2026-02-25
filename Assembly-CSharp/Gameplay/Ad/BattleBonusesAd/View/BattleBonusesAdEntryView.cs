using System;
using Gameplay.Ad.BattleBonusesAd.Controller;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DBB RID: 3515
	[Token(Token = "0x2000DBB")]
	public class BattleBonusesAdEntryView : MonoBehaviour
	{
		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116F")]
		public Button Button
		{
			[Token(Token = "0x60055C5")]
			[Address(RVA = "0xA365", Offset = "0xA365", VA = "0xA365")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001170")]
		public BacktimeViewUGUI BacktimeViewUGUI
		{
			[Token(Token = "0x60055C6")]
			[Address(RVA = "0xA366", Offset = "0xA366", VA = "0xA366")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C7")]
		[Address(RVA = "0xA367", Offset = "0xA367", VA = "0xA367")]
		private void Awake()
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C8")]
		[Address(RVA = "0xA368", Offset = "0xA368", VA = "0xA368")]
		private void OnDestroy()
		{
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C9")]
		[Address(RVA = "0xA369", Offset = "0xA369", VA = "0xA369")]
		private void Init()
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CA")]
		[Address(RVA = "0xA36A", Offset = "0xA36A", VA = "0xA36A")]
		private void Deinit()
		{
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CB")]
		[Address(RVA = "0xA36B", Offset = "0xA36B", VA = "0xA36B")]
		public BattleBonusesAdEntryView()
		{
		}

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0x18")]
		private BattleBonusesAdMediator _mediator;
	}
}
