using System;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000980 RID: 2432
	[Token(Token = "0x2000980")]
	public class CombatAnimationContentDecorator : CombatAnimation.IContent, IDisposable
	{
		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B5F")]
		public AssetDic SoundAsset
		{
			[Token(Token = "0x60039F0")]
			[Address(RVA = "0x8974", Offset = "0x8974", VA = "0x8974")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60039F1")]
			[Address(RVA = "0x8975", Offset = "0x8975", VA = "0x8975")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F2")]
		[Address(RVA = "0x8976", Offset = "0x8976", VA = "0x8976")]
		public CombatAnimationContentDecorator(IGameAudio audio, CombatAnimation.IContent content, string text, CombatEventsToast toast)
		{
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x8977", Offset = "0x8977", VA = "0x8977", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x14000187 RID: 391
		// (add) Token: 0x060039F4 RID: 14836 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060039F5 RID: 14837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000187")]
		private event Action<CombatAnimation.IContent> _onCompleteEvent
		{
			[Token(Token = "0x60039F4")]
			[Address(RVA = "0x8978", Offset = "0x8978", VA = "0x8978")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60039F5")]
			[Address(RVA = "0x8979", Offset = "0x8979", VA = "0x8979")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000188 RID: 392
		// (add) Token: 0x060039F6 RID: 14838 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060039F7 RID: 14839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000188")]
		public event Action<CombatAnimation.IContent> OnCompleteEvent
		{
			[Token(Token = "0x60039F6")]
			[Address(RVA = "0x897A", Offset = "0x897A", VA = "0x897A", Slot = "4")]
			add
			{
			}
			[Token(Token = "0x60039F7")]
			[Address(RVA = "0x897B", Offset = "0x897B", VA = "0x897B", Slot = "5")]
			remove
			{
			}
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F8")]
		[Address(RVA = "0x897C", Offset = "0x897C", VA = "0x897C")]
		private void HandleOnCompleteEvent(CombatAnimation.IContent content)
		{
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039F9")]
		[Address(RVA = "0x897D", Offset = "0x897D", VA = "0x897D")]
		public void SetContent(CombatAnimation.IContent content)
		{
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FA")]
		[Address(RVA = "0x897E", Offset = "0x897E", VA = "0x897E", Slot = "6")]
		public void Show()
		{
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FB")]
		[Address(RVA = "0x897F", Offset = "0x897F", VA = "0x897F", Slot = "7")]
		public void Hide()
		{
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039FC")]
		[Address(RVA = "0x8980", Offset = "0x8980", VA = "0x8980", Slot = "8")]
		public void Play(bool loop)
		{
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B60")]
		public Transform Transform
		{
			[Token(Token = "0x60039FD")]
			[Address(RVA = "0x8981", Offset = "0x8981", VA = "0x8981", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x0000B910 File Offset: 0x00009B10
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B61")]
		public bool IsLeft
		{
			[Token(Token = "0x60039FE")]
			[Address(RVA = "0x8982", Offset = "0x8982", VA = "0x8982", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60039FF")]
			[Address(RVA = "0x8983", Offset = "0x8983", VA = "0x8983", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[FieldOffset(Offset = "0xC")]
		private CombatAnimation.IContent _content;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		[FieldOffset(Offset = "0x10")]
		private CombatEventsToast _toast;

		// Token: 0x0400200D RID: 8205
		[Token(Token = "0x400200D")]
		[FieldOffset(Offset = "0x14")]
		private string _text;

		// Token: 0x0400200E RID: 8206
		[Token(Token = "0x400200E")]
		[FieldOffset(Offset = "0x18")]
		private IGameAudio _audio;
	}
}
