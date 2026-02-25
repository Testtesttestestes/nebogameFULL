using System;
using AssetContent;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;
using Utils;

namespace Gameplay.Competition.View
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	[AddComponentMenu("Competition/View/EntryPoint/CompetitionEpView")]
	public class CompetitionEpView : MonoBehaviour
	{
		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A83")]
		public CounterAutoHide Counter
		{
			[Token(Token = "0x600354E")]
			[Address(RVA = "0x8571", Offset = "0x8571", VA = "0x8571")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A84")]
		public GameImage Image
		{
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x8572", Offset = "0x8572", VA = "0x8572")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A85")]
		public MonoPointerClickHandler ClickSource
		{
			[Token(Token = "0x6003550")]
			[Address(RVA = "0x8573", Offset = "0x8573", VA = "0x8573")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x8574", Offset = "0x8574", VA = "0x8574")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x8575", Offset = "0x8575", VA = "0x8575")]
		private void Start()
		{
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x8576", Offset = "0x8576", VA = "0x8576")]
		public void SetOwnedRatingValue(ulong value)
		{
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x8577", Offset = "0x8577", VA = "0x8577")]
		public CompetitionEpView()
		{
		}

		// Token: 0x04001D25 RID: 7461
		[Token(Token = "0x4001D25")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickSource;

		// Token: 0x04001D26 RID: 7462
		[Token(Token = "0x4001D26")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImage _image;

		// Token: 0x04001D27 RID: 7463
		[Token(Token = "0x4001D27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _ownedRatingValue;

		// Token: 0x04001D28 RID: 7464
		[Token(Token = "0x4001D28")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x04001D29 RID: 7465
		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x20")]
		private IViewMediator _mediator;
	}
}
