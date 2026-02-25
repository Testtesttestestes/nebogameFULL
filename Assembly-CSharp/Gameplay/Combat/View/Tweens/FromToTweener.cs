using System;
using Core.Extensions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using Utils;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000931 RID: 2353
	[Token(Token = "0x2000931")]
	public class FromToTweener : FromToSpriteRenderTweener
	{
		// Token: 0x06003783 RID: 14211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x876E", Offset = "0x876E", VA = "0x876E")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x876F", Offset = "0x876F", VA = "0x876F")]
		private void Awake()
		{
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x8770", Offset = "0x8770", VA = "0x8770", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x8771", Offset = "0x8771", VA = "0x8771")]
		public new void Rollback()
		{
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x8772", Offset = "0x8772", VA = "0x8772")]
		public new void Play()
		{
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003788")]
		[Address(RVA = "0x8773", Offset = "0x8773", VA = "0x8773")]
		private void Play(in TransformExt.TransformData toTransformData, in Color toColor, float transformDelay, float fadeDelay, float transformDuration, float fadeDuration)
		{
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003789")]
		[Address(RVA = "0x8774", Offset = "0x8774", VA = "0x8774")]
		public FromToTweener()
		{
		}

		// Token: 0x04001EA3 RID: 7843
		[Token(Token = "0x4001EA3")]
		[FieldOffset(Offset = "0x40")]
		public TransformExt.TransformData FromTransform;

		// Token: 0x04001EA4 RID: 7844
		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x88")]
		[FormerlySerializedAs("_transfromDuration")]
		public float TransfromDuration;

		// Token: 0x04001EA5 RID: 7845
		[Token(Token = "0x4001EA5")]
		[FieldOffset(Offset = "0x8C")]
		[FormerlySerializedAs("_transformDelay")]
		public float TransformDelay;

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x90")]
		public TransformExt.TransformData ToTransform;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		[FieldOffset(Offset = "0xD8")]
		private TweenContainer _tweenContainer;
	}
}
