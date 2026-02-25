using System;
using Core.Net;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Tutorial;
using Protocol.World;
using Utils;

namespace ServicesNamespace
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	public class TutorialService : AbstractService
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x170000B4")]
		public override short ServiceId
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x5ABB", Offset = "0x5ABB", VA = "0x5ABB", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x5ABC", Offset = "0x5ABC", VA = "0x5ABC")]
		public OpToken<IMessage, object> StartTutorial(string language, ClientPlatform platform)
		{
			return null;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x5ABD", Offset = "0x5ABD", VA = "0x5ABD")]
		public OpToken<IMessage, object> LogTutorialStep(uint tutorialId, uint stepId, string parameters)
		{
			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x5ABE", Offset = "0x5ABE", VA = "0x5ABE")]
		public OpToken<IMessage, object> StartTutorialBattle()
		{
			return null;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5ABF", Offset = "0x5ABF", VA = "0x5ABF")]
		public OpToken<IMessage, object> ResumeTutorialBattle()
		{
			return null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5AC0", Offset = "0x5AC0", VA = "0x5AC0")]
		public OpToken<IMessage, object> GetUserInfo()
		{
			return null;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5AC1", Offset = "0x5AC1", VA = "0x5AC1")]
		public OpToken<IMessage, object> GetUserIsleInfo(ulong userId, ProtoGetUserIsleInfoCmd.Types.RequestedTypeInfo flag)
		{
			return null;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C3")]
		private OpToken<IMessage, object> Request<TAns>(string cmdName, TutorialCommands command, IMessage msg) where TAns : IMessage, new()
		{
			return null;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006C4")]
		private OpToken<IMessage, object> Request<TAns, TMsg>(string cmdName, TutorialCommands command, IMessage<TMsg> msg) where TAns : IMessage, new() where TMsg : IMessage<TMsg>
		{
			return null;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5AC2", Offset = "0x5AC2", VA = "0x5AC2")]
		public TutorialService()
		{
		}
	}
}
