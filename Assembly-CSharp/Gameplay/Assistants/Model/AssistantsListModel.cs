using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Assistants.Model
{
	// Token: 0x02000CA7 RID: 3239
	[Token(Token = "0x2000CA7")]
	public class AssistantsListModel : AbstractModel
	{
		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06004EC4 RID: 20164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EC5 RID: 20165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF2")]
		public RepeatedField<AssistantsDic> AssistantsDicts
		{
			[Token(Token = "0x6004EC4")]
			[Address(RVA = "0x9CED", Offset = "0x9CED", VA = "0x9CED")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EC5")]
			[Address(RVA = "0x9CEE", Offset = "0x9CEE", VA = "0x9CEE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06004EC6 RID: 20166 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004EC7 RID: 20167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FF3")]
		public List<BaseAssistant> Assistants
		{
			[Token(Token = "0x6004EC6")]
			[Address(RVA = "0x9CEF", Offset = "0x9CEF", VA = "0x9CEF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004EC7")]
			[Address(RVA = "0x9CF0", Offset = "0x9CF0", VA = "0x9CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x9CF1", Offset = "0x9CF1", VA = "0x9CF1", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x9CF2", Offset = "0x9CF2", VA = "0x9CF2")]
		public AssistantsListModel(Dictionary<AssistantsDic.Types.Assistants, Type> availAssistants, RepeatedField<AssistantsDic> assistantsDicts, UserData user)
		{
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6004ECA")]
		[Address(RVA = "0x9CF3", Offset = "0x9CF3", VA = "0x9CF3")]
		public bool TryGetAssistantByAccount(uint accountId, out BaseAssistant assistant)
		{
			return default(bool);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ECB")]
		[Address(RVA = "0x1D6A", Offset = "0x1D6A", VA = "0x1D6A")]
		public BaseAssistant Create(AssistantsDic dic)
		{
			return null;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ECC")]
		[Address(RVA = "0x9CF4", Offset = "0x9CF4", VA = "0x9CF4")]
		public BaseAssistant GetAssistant(AssistantsDic dic)
		{
			return null;
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ECD")]
		[Address(RVA = "0x9CF5", Offset = "0x9CF5", VA = "0x9CF5")]
		public BaseAssistant GetAssistant(uint id)
		{
			return null;
		}

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<AssistantsDic.Types.Assistants, Type> AvailAssistants;
	}
}
