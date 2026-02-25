using System;
using System.Runtime.CompilerServices;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Announcements;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public class AnnouncementsService : AbstractService
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700008E")]
		public override short ServiceId
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x5804", Offset = "0x5804", VA = "0x5804", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000013")]
		public event Action<ProtoGetListCmd.Types.Ans> ThereIsNewAnnouncementsEvent
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x5805", Offset = "0x5805", VA = "0x5805")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x5806", Offset = "0x5806", VA = "0x5806")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x5807", Offset = "0x5807", VA = "0x5807", Slot = "6")]
		protected override void ServerEventHandler(SrvAnswer evt)
		{
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5808", Offset = "0x5808", VA = "0x5808")]
		public OpToken<IMessage, object> GetList()
		{
			return null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5809", Offset = "0x5809", VA = "0x5809")]
		public OpToken<IMessage, object> Read(ulong id)
		{
			return null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x580A", Offset = "0x580A", VA = "0x580A")]
		public AnnouncementsService()
		{
		}
	}
}
