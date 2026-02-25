using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000987 RID: 2439
	[Token(Token = "0x2000987")]
	public class ToastCombatAnimation : ICombatAnimation, IDisposable
	{
		// Token: 0x1400018E RID: 398
		// (add) Token: 0x06003A33 RID: 14899 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A34 RID: 14900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018E")]
		public event Action<CombatAnimation.IContent> OnAnimExecuteEvent
		{
			[Token(Token = "0x6003A33")]
			[Address(RVA = "0x89AF", Offset = "0x89AF", VA = "0x89AF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A34")]
			[Address(RVA = "0x89B0", Offset = "0x89B0", VA = "0x89B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x0000B970 File Offset: 0x00009B70
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B67")]
		public bool IsPlaying
		{
			[Token(Token = "0x6003A35")]
			[Address(RVA = "0x89B1", Offset = "0x89B1", VA = "0x89B1")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A36")]
			[Address(RVA = "0x89B2", Offset = "0x89B2", VA = "0x89B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x89B3", Offset = "0x89B3", VA = "0x89B3")]
		public ToastCombatAnimation(float toastDuration)
		{
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x89B4", Offset = "0x89B4", VA = "0x89B4", Slot = "6")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path)
		{
			return null;
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A39")]
		[Address(RVA = "0x89B5", Offset = "0x89B5", VA = "0x89B5", Slot = "7")]
		public void Append(string path, bool isLeft)
		{
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3A")]
		[Address(RVA = "0x89B6", Offset = "0x89B6", VA = "0x89B6", Slot = "8")]
		public void Append(CombatAnimation.IContent content)
		{
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3B")]
		[Address(RVA = "0x89B7", Offset = "0x89B7", VA = "0x89B7", Slot = "9")]
		public void CancelLoad()
		{
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3C")]
		[Address(RVA = "0x89B8", Offset = "0x89B8", VA = "0x89B8", Slot = "10")]
		public void Stop()
		{
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3D")]
		[Address(RVA = "0x89B9", Offset = "0x89B9", VA = "0x89B9", Slot = "11")]
		public void Reset()
		{
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3E")]
		[Address(RVA = "0x89BA", Offset = "0x89BA", VA = "0x89BA", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A3F")]
		[Address(RVA = "0x89BB", Offset = "0x89BB", VA = "0x89BB")]
		private void StartAnimation()
		{
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A40")]
		[Address(RVA = "0x89BC", Offset = "0x89BC", VA = "0x89BC")]
		private void DelayedCall(CombatAnimation.IContent content)
		{
		}

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _toastDuration;

		// Token: 0x04002025 RID: 8229
		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x10")]
		private Queue<CombatAnimation.IContent> _contentQueue;

		// Token: 0x04002026 RID: 8230
		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x14")]
		private Tween _delayedCall;

		// Token: 0x02000988 RID: 2440
		[Token(Token = "0x2000988")]
		private class EmptyContent : CombatAnimation.IContent, IDisposable
		{
			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06003A41 RID: 14913 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000B68")]
			public Transform Transform
			{
				[Token(Token = "0x6003A41")]
				[Address(RVA = "0x89BD", Offset = "0x89BD", VA = "0x89BD", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06003A42 RID: 14914 RVA: 0x0000B988 File Offset: 0x00009B88
			// (set) Token: 0x06003A43 RID: 14915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B69")]
			public bool IsLeft
			{
				[Token(Token = "0x6003A42")]
				[Address(RVA = "0x89BE", Offset = "0x89BE", VA = "0x89BE", Slot = "10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003A43")]
				[Address(RVA = "0x89BF", Offset = "0x89BF", VA = "0x89BF", Slot = "11")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1400018F RID: 399
			// (add) Token: 0x06003A44 RID: 14916 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06003A45 RID: 14917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1400018F")]
			public event Action<CombatAnimation.IContent> OnCompleteEvent
			{
				[Token(Token = "0x6003A44")]
				[Address(RVA = "0x89C0", Offset = "0x89C0", VA = "0x89C0", Slot = "4")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003A45")]
				[Address(RVA = "0x89C1", Offset = "0x89C1", VA = "0x89C1", Slot = "5")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x06003A46 RID: 14918 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A46")]
			[Address(RVA = "0x89C2", Offset = "0x89C2", VA = "0x89C2", Slot = "12")]
			public void Dispose()
			{
			}

			// Token: 0x06003A47 RID: 14919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A47")]
			[Address(RVA = "0x89C3", Offset = "0x89C3", VA = "0x89C3", Slot = "7")]
			public void Hide()
			{
			}

			// Token: 0x06003A48 RID: 14920 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A48")]
			[Address(RVA = "0x89C4", Offset = "0x89C4", VA = "0x89C4", Slot = "8")]
			public void Play(bool loop)
			{
			}

			// Token: 0x06003A49 RID: 14921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A49")]
			[Address(RVA = "0x89C5", Offset = "0x89C5", VA = "0x89C5", Slot = "6")]
			public void Show()
			{
			}

			// Token: 0x06003A4A RID: 14922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A4A")]
			[Address(RVA = "0x89C6", Offset = "0x89C6", VA = "0x89C6")]
			public EmptyContent()
			{
			}
		}
	}
}
