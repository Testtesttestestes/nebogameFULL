using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Shapes;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	public abstract class AbstractGuideOutline : MonoBehaviour
	{
		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001ACC RID: 6860 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001ACD RID: 6861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AD")]
		public AbstractShape Shape
		{
			[Token(Token = "0x6001ACC")]
			[Address(RVA = "0x6C59", Offset = "0x6C59", VA = "0x6C59")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001ACD")]
			[Address(RVA = "0x6C5A", Offset = "0x6C5A", VA = "0x6C5A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0x6C5B", Offset = "0x6C5B", VA = "0x6C5B")]
		private void Awake()
		{
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACF")]
		[Address(RVA = "0x6C5C", Offset = "0x6C5C", VA = "0x6C5C")]
		public void SetSize(float width, float height)
		{
		}

		// Token: 0x06001AD0 RID: 6864
		[Token(Token = "0x6001AD0")]
		protected abstract void HandleSizeChanged(float width, float height);

		// Token: 0x06001AD1 RID: 6865
		[Token(Token = "0x6001AD1")]
		public abstract void StartAnimation(float delay);

		// Token: 0x06001AD2 RID: 6866
		[Token(Token = "0x6001AD2")]
		public abstract void StopAnimation();

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0x6C5D", Offset = "0x6C5D", VA = "0x6C5D")]
		protected AbstractGuideOutline()
		{
		}
	}
}
