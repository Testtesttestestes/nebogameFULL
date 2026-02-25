using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Gameplay.Combat.View.Tweens
{
	// Token: 0x02000930 RID: 2352
	[Token(Token = "0x2000930")]
	public class FromToSpriteRenderTweener : MonoBehaviour
	{
		// Token: 0x0600377C RID: 14204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377C")]
		[Address(RVA = "0x8769", Offset = "0x8769", VA = "0x8769")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377D")]
		[Address(RVA = "0x876A", Offset = "0x876A", VA = "0x876A")]
		private void Awake()
		{
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377E")]
		[Address(RVA = "0x876B", Offset = "0x876B", VA = "0x876B", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377F")]
		[Address(RVA = "0x19CD", Offset = "0x19CD", VA = "0x19CD")]
		public void Rollback()
		{
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003780")]
		[Address(RVA = "0x876C", Offset = "0x876C", VA = "0x876C")]
		public void Play(in Color toColor, float fadeDelay, float fadeDuration)
		{
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003781")]
		[Address(RVA = "0x19CF", Offset = "0x19CF", VA = "0x19CF")]
		public void Play()
		{
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x876D", Offset = "0x876D", VA = "0x876D")]
		public FromToSpriteRenderTweener()
		{
		}

		// Token: 0x04001E9D RID: 7837
		[Token(Token = "0x4001E9D")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("HandleChildrent")]
		public bool HandleChilds;

		// Token: 0x04001E9E RID: 7838
		[Token(Token = "0x4001E9E")]
		[FieldOffset(Offset = "0x14")]
		public Color FromColor;

		// Token: 0x04001E9F RID: 7839
		[Token(Token = "0x4001E9F")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("_fadeDuration")]
		public float FadeDuration;

		// Token: 0x04001EA0 RID: 7840
		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_fadeDelay")]
		public float FadeDelay;

		// Token: 0x04001EA1 RID: 7841
		[Token(Token = "0x4001EA1")]
		[FieldOffset(Offset = "0x2C")]
		public Color ToColor;

		// Token: 0x04001EA2 RID: 7842
		[Token(Token = "0x4001EA2")]
		[FieldOffset(Offset = "0x3C")]
		public List<FromToSpriteRenderTweener> Childrent;
	}
}
