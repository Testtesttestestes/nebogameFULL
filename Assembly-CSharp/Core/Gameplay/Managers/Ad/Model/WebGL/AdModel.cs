using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Services;

namespace Core.Gameplay.Managers.Ad.Model.WebGL
{
	// Token: 0x02001224 RID: 4644
	[Token(Token = "0x2001224")]
	public class AdModel : AbstractAdModel
	{
		// Token: 0x06006DF9 RID: 28153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DF9")]
		[Address(RVA = "0xB8AF", Offset = "0xB8AF", VA = "0xB8AF")]
		public AdModel(IGame game, UserData user)
		{
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06006DFA RID: 28154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001657")]
		public override uint[] SupportedAdProviders
		{
			[Token(Token = "0x6006DFA")]
			[Address(RVA = "0xB8B0", Offset = "0xB8B0", VA = "0xB8B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DFB")]
		[Address(RVA = "0xB8B1", Offset = "0xB8B1", VA = "0xB8B1")]
		public void InitSupportedAds(params AdSource[] ads)
		{
		}

		// Token: 0x04003985 RID: 14725
		[Token(Token = "0x4003985")]
		[FieldOffset(Offset = "0x20")]
		private uint[] _supportedAdProviders;
	}
}
