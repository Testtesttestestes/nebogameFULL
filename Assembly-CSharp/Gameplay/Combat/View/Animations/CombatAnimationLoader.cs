using System;
using System.Runtime.CompilerServices;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Animations
{
	// Token: 0x02000982 RID: 2434
	[Token(Token = "0x2000982")]
	public class CombatAnimationLoader : CombatAnimation.IContent, IDisposable
	{
		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x0000B940 File Offset: 0x00009B40
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B63")]
		public bool IsLeft
		{
			[Token(Token = "0x6003A09")]
			[Address(RVA = "0x898D", Offset = "0x898D", VA = "0x898D", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A0A")]
			[Address(RVA = "0x898E", Offset = "0x898E", VA = "0x898E", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1400018B RID: 395
		// (add) Token: 0x06003A0B RID: 14859 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003A0C RID: 14860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400018B")]
		public event Action<CombatAnimation.IContent> OnCompleteEvent
		{
			[Token(Token = "0x6003A0B")]
			[Address(RVA = "0x898F", Offset = "0x898F", VA = "0x898F", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003A0C")]
			[Address(RVA = "0x8990", Offset = "0x8990", VA = "0x8990", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x8991", Offset = "0x8991", VA = "0x8991")]
		public CombatAnimationLoader(int sortingOrder)
		{
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A0E")]
		[Address(RVA = "0x8992", Offset = "0x8992", VA = "0x8992")]
		public OpToken<CombatAnimation.IContent, CombatAnimation.IContent> Load(string path, Transform parent)
		{
			return null;
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x8993", Offset = "0x8993", VA = "0x8993")]
		private void HandleLoadSuccess(IGameAnimation gameAnimation, string resourceUrl)
		{
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A10")]
		[Address(RVA = "0x8994", Offset = "0x8994", VA = "0x8994")]
		private void HandleCompleteEvent(IGameAnimation obj)
		{
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x8995", Offset = "0x8995", VA = "0x8995")]
		private void HandleLoadFail(string path)
		{
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x8996", Offset = "0x8996", VA = "0x8996", Slot = "8")]
		public void Play(bool loop = false)
		{
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A13")]
		[Address(RVA = "0x8997", Offset = "0x8997", VA = "0x8997", Slot = "6")]
		public void Show()
		{
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A14")]
		[Address(RVA = "0x8998", Offset = "0x8998", VA = "0x8998", Slot = "7")]
		public void Hide()
		{
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B64")]
		public Transform Transform
		{
			[Token(Token = "0x6003A15")]
			[Address(RVA = "0x8999", Offset = "0x8999", VA = "0x8999", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A16")]
		[Address(RVA = "0x899A", Offset = "0x899A", VA = "0x899A", Slot = "12")]
		public void Dispose()
		{
		}

		// Token: 0x04002013 RID: 8211
		[Token(Token = "0x4002013")]
		[FieldOffset(Offset = "0xC")]
		public string Path;

		// Token: 0x04002014 RID: 8212
		[Token(Token = "0x4002014")]
		[FieldOffset(Offset = "0x10")]
		private IGameAnimation _animation;

		// Token: 0x04002015 RID: 8213
		[Token(Token = "0x4002015")]
		[FieldOffset(Offset = "0x14")]
		private Transform _parent;

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _sortingOrder;

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x1C")]
		private OpToken<CombatAnimation.IContent, CombatAnimation.IContent> _loadOperation;
	}
}
