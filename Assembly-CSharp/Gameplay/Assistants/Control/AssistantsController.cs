using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Assistants.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Services;
using ServicesNamespace;
using Utils;

namespace Gameplay.Assistants.Control
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000CB6")]
	public class AssistantsController : AbstractController<AssistantsListModel, AssistantsEvents>
	{
		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F54 RID: 20308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700101F")]
		public ServicesService ServicesService
		{
			[Token(Token = "0x6004F53")]
			[Address(RVA = "0x9D7B", Offset = "0x9D7B", VA = "0x9D7B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F54")]
			[Address(RVA = "0x9D7C", Offset = "0x9D7C", VA = "0x9D7C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x9D7D", Offset = "0x9D7D", VA = "0x9D7D", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x9D7E", Offset = "0x9D7E", VA = "0x9D7E")]
		public AssistantsController(AssistantsListModel model, AssistantsEvents events)
		{
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x9D7F", Offset = "0x9D7F", VA = "0x9D7F", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x9D80", Offset = "0x9D80", VA = "0x9D80")]
		private void Internal_HandleRun(IEnumerable<ProtoGetAssistantsStatusAns.Types.Info> infos)
		{
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x9D81", Offset = "0x9D81", VA = "0x9D81")]
		private void GetAssistantsStatusService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x9D82", Offset = "0x9D82", VA = "0x9D82")]
		private void RunAssistants(IEnumerable<ProtoGetAssistantsStatusAns.Types.Info> infos)
		{
		}
	}
}
