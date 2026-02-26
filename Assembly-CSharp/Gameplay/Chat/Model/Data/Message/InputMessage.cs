using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B18 RID: 2840
	[Token(Token = "0x2000B18")]
	public class InputMessage
	{
		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x0000CF18 File Offset: 0x0000B118
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D92")]
		public ChatMessage.Types.ChatMessageTypes MessageType
		{
			[Token(Token = "0x6004493")]
			[Address(RVA = "0x9340", Offset = "0x9340", VA = "0x9340")]
			[CompilerGenerated]
			get
			{
				return ChatMessage.Types.ChatMessageTypes.UnknownChatMessageType;
			}
			[Token(Token = "0x6004494")]
			[Address(RVA = "0x9341", Offset = "0x9341", VA = "0x9341")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D93")]
		public string UserNick
		{
			[Token(Token = "0x6004495")]
			[Address(RVA = "0x9342", Offset = "0x9342", VA = "0x9342")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004496")]
			[Address(RVA = "0x9343", Offset = "0x9343", VA = "0x9343")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D94")]
		public string MessageText
		{
			[Token(Token = "0x6004497")]
			[Address(RVA = "0x9344", Offset = "0x9344", VA = "0x9344")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004498")]
			[Address(RVA = "0x9345", Offset = "0x9345", VA = "0x9345")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004499")]
		[Address(RVA = "0x9346", Offset = "0x9346", VA = "0x9346")]
		public InputMessage(string text)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Chat_Model_Data_Message_InputMessage___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57b59 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1706);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1715);
		    DAT_ram_00a57b59 = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0xc),0);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 == 1) {
		      uVar2 = System_Int32__ToString
		                        (StringLiteral_1715,*(undefined4 *)(param1 + 0xc),StringLiteral_118,
		                         *(undefined4 *)(param1 + 0x10),0);
		      return uVar2;
		    }
		    if (((iVar1 != 2) && (iVar1 != 3)) && (iVar1 == 4)) {
		      uVar2 = System_Int32__ToString
		                        (StringLiteral_1706,*(undefined4 *)(param1 + 0xc),StringLiteral_118,
		                         *(undefined4 *)(param1 + 0x10),0);
		      return uVar2;
		    }
		  }
		  return *(undefined4 *)(param1 + 0x10);
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Chat_Model_Data_Message_InputMessage___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57b59 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_118);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1706);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1715);
		    DAT_ram_00a57b59 = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0xc),0);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(param1 + 8);
		    if (iVar1 == 1) {
		      uVar2 = System_Int32__ToString
		                        (StringLiteral_1715,*(undefined4 *)(param1 + 0xc),StringLiteral_118,
		                         *(undefined4 *)(param1 + 0x10),0);
		      return uVar2;
		    }
		    if (((iVar1 != 2) && (iVar1 != 3)) && (iVar1 == 4)) {
		      uVar2 = System_Int32__ToString
		                        (StringLiteral_1706,*(undefined4 *)(param1 + 0xc),StringLiteral_118,
		                         *(undefined4 *)(param1 + 0x10),0);
		      return uVar2;
		    }
		  }
		  return *(undefined4 *)(param1 + 0x10);
		}
		*/

		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x9347", Offset = "0x9347", VA = "0x9347")]
		public InputMessage(string text, string userNick)
		{
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600449B")]
		[Address(RVA = "0x9348", Offset = "0x9348", VA = "0x9348", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4
		Gameplay_Chat_Model_Data_Message_InputMessage__ToString(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b5a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1705);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1714);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57b5a = '\x01';
		  }
		  iVar2 = UnityEngine_WWWTranscoder__SevenBitClean(param1,StringLiteral_1705,0);
		  if ((iVar2 != -1) ||
		     (iVar2 = UnityEngine_WWWTranscoder__SevenBitClean(param1,StringLiteral_1714,0), iVar2 != -1)) {
		    uVar1 = 0;
		    iVar2 = System_Net_WebConnection__ReadLine(param1,0x20,0,0);
		    if (1 < *(int *)(iVar2 + 0xc)) {
		      uVar1 = *(undefined4 *)(iVar2 + 0x14);
		    }
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		    if (iVar2 == 0) {
		      param1 = func_ii_7088(param1,uVar1,StringLiteral_5,0);
		    }
		  }
		  uVar1 = func_ii_7088(param1,StringLiteral_1714,StringLiteral_5,0);
		  uVar1 = func_ii_7088(uVar1,StringLiteral_1705,StringLiteral_5,0);
		  uVar1 = System_Convert__FromBase64String(uVar1,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x9349", Offset = "0x9349", VA = "0x9349")]
		public static string GetPayload(string text)
		{
			return null;
		}

		// Token: 0x040025D4 RID: 9684
		[Token(Token = "0x40025D4")]
		public const string PRIVATE_MSG_CHARS = "/private";

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		public const string TO_MSG_CHARS = "/to";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MessageText ---
		void Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b58 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1705);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1714);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a57b58 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = 1;
		  iVar2 = UnityEngine_WWWTranscoder__SevenBitClean(param2,StringLiteral_1705,0);
		  if ((iVar2 != -1) ||
		     (iVar2 = UnityEngine_WWWTranscoder__SevenBitClean(param2,StringLiteral_1714,0), iVar2 != -1)) {
		    uVar1 = 0;
		    iVar2 = UnityEngine_WWWTranscoder__SevenBitClean(param2,StringLiteral_1705,0);
		    if (iVar2 != -1) {
		      *(undefined4 *)(param1 + 8) = 4;
		    }
		    iVar2 = System_Net_WebConnection__ReadLine(param2,0x20,0,0);
		    if (1 < *(int *)(iVar2 + 0xc)) {
		      uVar1 = *(undefined4 *)(iVar2 + 0x14);
		    }
		    *(undefined4 *)(param1 + 0xc) = uVar1;
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		    if (iVar2 == 0) {
		      uVar1 = System_Convert__FromBase64String(*(undefined4 *)(param1 + 0xc),0);
		      *(undefined4 *)(param1 + 0xc) = uVar1;
		    }
		  }
		  uVar1 = func_ii_7088(param2,StringLiteral_1714,StringLiteral_5,0);
		  uVar1 = func_ii_7088(uVar1,StringLiteral_1705,StringLiteral_5,0);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(param1 + 0xc),0);
		  if (iVar2 == 0) {
		    uVar1 = func_ii_7088(uVar1,*(undefined4 *)(param1 + 0xc),StringLiteral_5,0);
		  }
		  uVar1 = System_Convert__FromBase64String(uVar1,0);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

}
