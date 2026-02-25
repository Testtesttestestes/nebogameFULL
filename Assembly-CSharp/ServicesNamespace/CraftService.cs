using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Craft;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public class CraftService : AbstractService
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x1700009E")]
		public override short ServiceId
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x5947", Offset = "0x5947", VA = "0x5947", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000060")]
		public event Action<UserProfession> ProfessionChangedEvent
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x5948", Offset = "0x5948", VA = "0x5948")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x5949", Offset = "0x5949", VA = "0x5949")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000061")]
		public event Action<UserScheme> SchemeChangedEvent
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x594A", Offset = "0x594A", VA = "0x594A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x594B", Offset = "0x594B", VA = "0x594B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000062")]
		public event Action<ProtoCraftSlotsChangedEvt> CraftSlotsChangedEvent
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x594C", Offset = "0x594C", VA = "0x594C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x594D", Offset = "0x594D", VA = "0x594D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000063")]
		public event Action<ProtoManufactureGetInfoAns> ManufactureDismantleProgressEvent
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x594E", Offset = "0x594E", VA = "0x594E")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x594F", Offset = "0x594F", VA = "0x594F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x5950", Offset = "0x5950", VA = "0x5950", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x5951", Offset = "0x5951", VA = "0x5951")]
		public OpToken<IMessage, object> GetUserProfessions()
		{
			return null;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x5952", Offset = "0x5952", VA = "0x5952")]
		public OpToken<IMessage, object> GetUserCraftSlotsInfo()
		{
			return null;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x5953", Offset = "0x5953", VA = "0x5953")]
		public OpToken<IMessage, object> AcquireProfession(uint professionId)
		{
			return null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x5954", Offset = "0x5954", VA = "0x5954")]
		public OpToken<IMessage, object> DismantleArtifact(int slotId, bool sellDrop = false, bool wholeStack = false, ulong ownerId = 0UL)
		{
			return null;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x5955", Offset = "0x5955", VA = "0x5955")]
		public OpToken<IMessage, object> OpenCraftSlot(uint craftSlotId)
		{
			return null;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x5956", Offset = "0x5956", VA = "0x5956")]
		public OpToken<IMessage, object> StartCraft(uint schemeId, uint quantity)
		{
			return null;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x5957", Offset = "0x5957", VA = "0x5957")]
		public OpToken<IMessage, object> CancelCraft(uint craftSlotId)
		{
			return null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x5958", Offset = "0x5958", VA = "0x5958")]
		public OpToken<IMessage, object> SpeedupCraft(uint craftSlotId)
		{
			return null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x5959", Offset = "0x5959", VA = "0x5959")]
		public OpToken<IMessage, object> GetUserSchemes()
		{
			return null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x595A", Offset = "0x595A", VA = "0x595A")]
		public OpToken<IMessage, object> DismantleArtifactFromDrop(ulong artifactId, bool sellDrop = false, bool wholeStack = false)
		{
			return null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x595B", Offset = "0x595B", VA = "0x595B")]
		public OpToken<IMessage, object> RemoveUserSheme(uint schemeId)
		{
			return null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x595C", Offset = "0x595C", VA = "0x595C")]
		public OpToken<IMessage, object> ManufactureGetInfo()
		{
			return null;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x595D", Offset = "0x595D", VA = "0x595D")]
		public OpToken<IMessage, object> ManufacturePutArtifact(ulong artifactId)
		{
			return null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x595E", Offset = "0x595E", VA = "0x595E")]
		public OpToken<IMessage, object> ManufactureTakeArtifact(ulong artifactId, uint slotId)
		{
			return null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x595F", Offset = "0x595F", VA = "0x595F")]
		public OpToken<IMessage, object> ManufactureDismantle(uint stackSize)
		{
			return null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x5960", Offset = "0x5960", VA = "0x5960")]
		public CraftService()
		{
		}
	}
}
