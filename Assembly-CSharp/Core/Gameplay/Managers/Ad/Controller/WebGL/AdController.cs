using System;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Model;
using Core.Gameplay.Managers.Ad.Providers;
using Il2CppDummyDll;
using Protocol.Services;
using ServicesNamespace;

namespace Core.Gameplay.Managers.Ad.Controller.WebGL
{
	// Token: 0x0200122B RID: 4651
	[Token(Token = "0x200122B")]
	public class AdController : AbstractAdController
	{
		// Token: 0x06006E26 RID: 28198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E26")]
		[Address(RVA = "0xB8D6", Offset = "0xB8D6", VA = "0xB8D6")]
		public AdController(ServicesService servicesService, AbstractAdModel model, AdEvents events)
		{
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006E27")]
		[Address(RVA = "0xB8D7", Offset = "0xB8D7", VA = "0xB8D7", Slot = "14")]
		protected override IAdProvider CreateAdProvider(AdSource providerId)
		{
			return null;
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E28")]
		[Address(RVA = "0xB8D8", Offset = "0xB8D8", VA = "0xB8D8", Slot = "15")]
		protected override void InitializeAdProvidersPreProcess()
		{
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E29")]
		[Address(RVA = "0xB8D9", Offset = "0xB8D9", VA = "0xB8D9", Slot = "16")]
		protected override void InitializeAdProvidersPostProcess()
		{
		}
	}
}
