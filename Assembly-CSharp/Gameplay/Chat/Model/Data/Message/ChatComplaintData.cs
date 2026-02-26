using System;
using System.Runtime.CompilerServices;
using Gameplay.Chat.Model.Data.Message.Format;
using Il2CppDummyDll;
using Protocol.Chat;

namespace Gameplay.Chat.Model.Data.Message
{
	// Token: 0x02000B14 RID: 2836
	[Token(Token = "0x2000B14")]
	public class ChatComplaintData : ChatMessageData
	{
		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004478 RID: 17528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D87")]
		public RoomKey MessageRoomKey
		{
			[Token(Token = "0x6004477")]
			[Address(RVA = "0x9327", Offset = "0x9327", VA = "0x9327")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004478")]
			[Address(RVA = "0x9328", Offset = "0x9328", VA = "0x9328")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D88")]
		public ChatMessageData Message
		{
			[Token(Token = "0x6004479")]
			[Address(RVA = "0x9329", Offset = "0x9329", VA = "0x9329")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x932A", Offset = "0x932A", VA = "0x932A")]
		public ChatComplaintData(uint id, RoomKey messageRoomKey, ChatMessageData message, ChatVisitorData chatUser, IChatMsgPresenter presenter)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Chat_Model_Data_Message_ChatComplaintData___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x1c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                    (*(int **)(param1 + 0x1c),param2,*(undefined4 *)(iVar2 + 0xf4));
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600447B RID: 17531 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600447B")]
		[Address(RVA = "0x932B", Offset = "0x932B", VA = "0x932B", Slot = "6")]
		public override string GetText(MessageDrawTarget target)
		{
		/* --- GHIDRA: GetText ---
		void Gameplay_Chat_Model_Data_Message_ChatComplaintData__GetText
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf8) * 4))
		            (*(int **)(param1 + 0x1c),param2,*(undefined4 *)(iVar1 + 0xfc));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600447C")]
		[Address(RVA = "0x932C", Offset = "0x932C", VA = "0x932C", Slot = "7")]
		public override void SetText(string value)
		{
		/* --- GHIDRA: SetText ---
		undefined4
		Gameplay_Chat_Model_Data_Message_ChatComplaintData__SetText(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 param2_00;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57b53 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8655);
		    DAT_ram_00a57b53 = '\x01';
		  }
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = Utils_TimeUtils__Format(0);
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  System_DateTimeOffset__FromUnixTimeSeconds(&local_20,param2_00,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  System_DateTimeOffset__ParseExact(&local_30,&local_10,0);
		  local_8 = local_28;
		  local_10 = local_30;
		  uVar1 = System_DateTimeOffset__ToString(&local_10,StringLiteral_8655,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D89")]
		public override string TimeString
		{
			[Token(Token = "0x600447D")]
			[Address(RVA = "0x932D", Offset = "0x932D", VA = "0x932D", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		// (set) Token: 0x0600447F RID: 17535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D8A")]
		public override bool IsReDrawRequired
		{
			[Token(Token = "0x600447E")]
			[Address(RVA = "0x932E", Offset = "0x932E", VA = "0x932E", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600447F")]
			[Address(RVA = "0x932F", Offset = "0x932F", VA = "0x932F", Slot = "5")]
			set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Message ---
		void Gameplay_Chat_Model_Data_Message_ChatComplaintData__get_Message
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0xc) = param6;
		  return;
		}
		*/


		/* --- GHIDRA: get_TimeString ---
		undefined4
		Gameplay_Chat_Model_Data_Message_ChatComplaintData__get_TimeString(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x1c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                    (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar2 + 0xe4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsReDrawRequired ---
		void Gameplay_Chat_Model_Data_Message_ChatComplaintData__get_IsReDrawRequired
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),param2,*(undefined4 *)(iVar1 + 0xec));
		  return;
		}
		*/

}
