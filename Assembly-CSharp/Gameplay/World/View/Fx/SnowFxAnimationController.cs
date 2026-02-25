using System;
using System.Collections.Generic;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View.Fx
{
	// Token: 0x0200035A RID: 858
	[Token(Token = "0x200035A")]
	public class SnowFxAnimationController : SnowFxControllerBase
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x658F", Offset = "0x658F", VA = "0x658F", Slot = "4")]
		protected override void ValidateEnable(bool enable)
		{
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x6590", Offset = "0x6590", VA = "0x6590")]
		private void OnEnable()
		{
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x6591", Offset = "0x6591", VA = "0x6591")]
		private void OnDisable()
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x6592", Offset = "0x6592", VA = "0x6592")]
		private void SwitchAnimations(bool enable)
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x6593", Offset = "0x6593", VA = "0x6593")]
		public SnowFxAnimationController()
		{
		}

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private List<GameSpineUiAnimation> _animations;
	}
}
