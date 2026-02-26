using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B17 RID: 2839
	[Token(Token = "0x2000B17")]
	public class ChatUserMessageData : ChatMessageData
	{
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600448C RID: 17548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8F")]
		[CanBeNull]
		public ChatVisitorData Sender
		{
			[Token(Token = "0x600448B")]
			[Address(RVA = "0x9338", Offset = "0x9338", VA = "0x9338")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600448C")]
			[Address(RVA = "0x9339", Offset = "0x9339", VA = "0x9339")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D90")]
		[CanBeNull]
		public ChatVisitorData Addressee
		{
			[Token(Token = "0x600448D")]
			[Address(RVA = "0x933A", Offset = "0x933A", VA = "0x933A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600448E")]
			[Address(RVA = "0x933B", Offset = "0x933B", VA = "0x933B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448F")]
		[Address(RVA = "0x933C", Offset = "0x933C", VA = "0x933C")]
		public ChatUserMessageData(ChatMessage source, ChatVisitorData chatUser, IChatMsgPresenter presenter)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Chat_Model_Data_Message_ChatUserMessageData___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57b55 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_Model_Data_Message_Format_IChatMsgPresenter_TypeInfo);
		    DAT_ram_00a57b55 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x24),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string__TryGetValue__
		                    );
		  if (iVar2 == 0) {
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0xc);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_Message_Format_IChatMsgPresenter_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e27066;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_Message_Format_IChatMsgPresenter_TypeInfo
		                                  ,0);
		code_r0x80e27066:
		    local_4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param1,param2,puVar3[1]);
		    func_ii_10812(*(undefined4 *)(param1 + 0x24),param2,local_4,
		                  Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string__Add__);
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x06004490 RID: 17552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004490")]
		[Address(RVA = "0x933D", Offset = "0x933D", VA = "0x933D", Slot = "6")]
		public override string GetText(MessageDrawTarget target)
		{
		/* --- GHIDRA: GetText ---
		void Gameplay_Chat_Model_Data_Message_ChatUserMessageData__GetText
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57b56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string__Clear__);
		    DAT_ram_00a57b56 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (param1[9],
		             Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string__Clear__);
		  Protocol_Chat_ChatMessage__get_Text(param1[8],param2,0);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,1,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004491 RID: 17553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004491")]
		[Address(RVA = "0x933E", Offset = "0x933E", VA = "0x933E", Slot = "7")]
		public override void SetText(string value)
		{
		/* --- GHIDRA: SetText ---
		int Gameplay_Chat_Model_Data_Message_ChatUserMessageData__SetText(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined8 param2_00;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57b57 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8655);
		    DAT_ram_00a57b57 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x28);
		  if (iVar1 == 0) {
		    param2_00 = *(undefined8 *)(*(int *)(param1 + 0x20) + 0x28);
		    if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTimeOffset_TypeInfo);
		    }
		    System_DateTimeOffset__FromUnixTimeSeconds(&local_20,param2_00,0);
		    local_8 = local_18;
		    local_10 = local_20;
		    System_DateTimeOffset__ParseExact(&local_30,&local_10,0);
		    local_8 = local_28;
		    local_10 = local_30;
		    iVar1 = System_DateTimeOffset__ToString(&local_10,StringLiteral_8655,0);
		    *(int *)(param1 + 0x28) = iVar1;
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D91")]
		public override string TimeString
		{
			[Token(Token = "0x6004492")]
			[Address(RVA = "0x933F", Offset = "0x933F", VA = "0x933F", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x040025D1 RID: 9681
		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x20")]
		[NotNull]
		public readonly ChatMessage SourceMessage;

		// Token: 0x040025D2 RID: 9682
		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<MessageDrawTarget, string> _cachedTexts;

		// Token: 0x040025D3 RID: 9683
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x28")]
		private string _timeString;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Addressee ---
		void Gameplay_Chat_Model_Data_Message_ChatUserMessageData__set_Addressee
		               (int *param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57b54 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_MessageDrawTarget__string__TypeInfo);
		    DAT_ram_00a57b54 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0xc);
		  param1[4] = param3;
		  param1[2] = iVar1;
		  param1[3] = param4;
		  iVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_MessageDrawTarget__string__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (iVar1,Method_System_Collections_Generic_Dictionary_MessageDrawTarget__string___ctor__);
		  param1[8] = param2;
		  param1[9] = iVar1;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,1,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/

}
