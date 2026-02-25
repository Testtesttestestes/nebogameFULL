using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D12 RID: 3346
	[Token(Token = "0x2000D12")]
	public class IsleAnimationButtonsView : MonoBehaviour
	{
		// Token: 0x140001F0 RID: 496
		// (add) Token: 0x060051A6 RID: 20902 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060051A7 RID: 20903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F0")]
		public event Action<IsleAnimationsDic> ButtonClickedEvent
		{
			[Token(Token = "0x60051A6")]
			[Address(RVA = "0x9F81", Offset = "0x9F81", VA = "0x9F81")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60051A7")]
			[Address(RVA = "0x9F82", Offset = "0x9F82", VA = "0x9F82")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001086")]
		public Dictionary<IsleAnimationsDic, GameAnimatedButton> Buttons
		{
			[Token(Token = "0x60051A8")]
			[Address(RVA = "0x9F83", Offset = "0x9F83", VA = "0x9F83")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051A9")]
		[Address(RVA = "0x9F84", Offset = "0x9F84", VA = "0x9F84")]
		private void Awake()
		{
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AA")]
		[Address(RVA = "0x9F85", Offset = "0x9F85", VA = "0x9F85")]
		private void OnDestroy()
		{
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AB")]
		[Address(RVA = "0x9F86", Offset = "0x9F86", VA = "0x9F86")]
		public void SetButtonAvailability(bool available)
		{
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60051AC")]
		[Address(RVA = "0x1E0A", Offset = "0x1E0A", VA = "0x1E0A")]
		public GameAnimatedButton AddButton(IsleAnimationsDic isleAnimationsDic)
		{
			return null;
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x60051AD")]
		[Address(RVA = "0x9F87", Offset = "0x9F87", VA = "0x9F87")]
		private bool TryGetButtonData(GameAnimatedButton button, out IsleAnimationsDic animationsDic)
		{
			return default(bool);
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AE")]
		[Address(RVA = "0x9F88", Offset = "0x9F88", VA = "0x9F88")]
		private void ButtonOnClickEvent(GameAnimatedButton button)
		{
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051AF")]
		[Address(RVA = "0x9F89", Offset = "0x9F89", VA = "0x9F89")]
		public void RemoveAllButtons()
		{
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051B0")]
		[Address(RVA = "0x9F8A", Offset = "0x9F8A", VA = "0x9F8A")]
		public IsleAnimationButtonsView()
		{
		}

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimatedButton _buttonPrefab;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002C63 RID: 11363
		[Token(Token = "0x4002C63")]
		[FieldOffset(Offset = "0x18")]
		private IsleAnimationButtonsViewMediator _mediator;
	}
}
