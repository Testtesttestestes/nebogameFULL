using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Consts;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public class LocationService : AbstractService
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x170000A3")]
		public override short ServiceId
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x5991", Offset = "0x5991", VA = "0x5991", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x5992", Offset = "0x5992", VA = "0x5992")]
		public OpToken<IMessage, object> ChangeLocation(LocationTypes type, ulong id)
		{
			return null;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x5993", Offset = "0x5993", VA = "0x5993")]
		public OpToken<IMessage, object> GetLocationInfo(ulong userId)
		{
			return null;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x5994", Offset = "0x5994", VA = "0x5994")]
		public LocationService()
		{
		}
	}
}
