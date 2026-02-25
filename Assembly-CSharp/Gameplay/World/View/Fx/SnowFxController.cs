using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View.Fx
{
	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	public class SnowFxController : SnowFxControllerBase
	{
		// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x659A", Offset = "0x659A", VA = "0x659A", Slot = "4")]
		protected override void ValidateEnable(bool enable)
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x659B", Offset = "0x659B", VA = "0x659B")]
		public SnowFxController()
		{
		}

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ParticleSystem _buttonParticles;
	}
}
