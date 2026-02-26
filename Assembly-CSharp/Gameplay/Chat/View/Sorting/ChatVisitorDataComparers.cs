using System;
using Core.Sorting;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Chat.View.Sorting
{
	// Token: 0x02000AF2 RID: 2802
	[Token(Token = "0x2000AF2")]
	public class ChatVisitorDataComparers
	{
		// Token: 0x0600439F RID: 17311 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x9253", Offset = "0x9253", VA = "0x9253")]
		private static int CompareLevel(ChatVisitorData x, ChatVisitorData y)
		{
		/* --- GHIDRA: CompareLevel ---
		undefined4
		Gameplay_Chat_View_Sorting_ChatVisitorDataComparers__CompareLevel
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_String__CompareTo
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x18),
		                     *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x18),0);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x9254", Offset = "0x9254", VA = "0x9254")]
		private static int CompareNick(ChatVisitorData x, ChatVisitorData y)
		{
		/* --- GHIDRA: CompareNick ---
		undefined4
		Gameplay_Chat_View_Sorting_ChatVisitorDataComparers__CompareNick
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0x24);
		  uVar1 = System_UInt32__CompareTo
		                    (&local_4,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x24),0);
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x9255", Offset = "0x9255", VA = "0x9255")]
		private static int CompareCult(ChatVisitorData x, ChatVisitorData y)
		{
			return 0;
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043A2")]
		[Address(RVA = "0x9256", Offset = "0x9256", VA = "0x9256")]
		public ChatVisitorDataComparers()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Chat_View_Sorting_ChatVisitorDataComparers___ctor
		              (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  iVar1 = System_String__CompareTo
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x18),
		                     *(undefined4 *)(*(int *)(*(int *)(param3 + 0x14) + 0xc) + 0x18),0);
		  if (iVar1 == 0) {
		    local_8 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x20);
		    iVar1 = System_UInt32__CompareTo
		                      (&local_8,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x14) + 0xc) + 0x20),0);
		    if (iVar1 == 0) {
		      local_4 = *(undefined4 *)(*(int *)(*(int *)(param2 + 0x14) + 0xc) + 0x24);
		      iVar1 = System_UInt32__CompareTo
		                        (&local_4,*(undefined4 *)(*(int *)(*(int *)(param3 + 0x14) + 0xc) + 0x24),0)
		      ;
		    }
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x02000AF3 RID: 2803
		[Token(Token = "0x2000AF3")]
		public class ByNick : AbstractGameDataComparer<ChatVisitorData>
		{
			// Token: 0x060043A3 RID: 17315 RVA: 0x0000CC30 File Offset: 0x0000AE30
			[Token(Token = "0x60043A3")]
			[Address(RVA = "0x9257", Offset = "0x9257", VA = "0x9257", Slot = "8")]
			public override int Compare(ChatVisitorData x, ChatVisitorData y)
			{
				return 0;
			}

			// Token: 0x17000D54 RID: 3412
			// (get) Token: 0x060043A4 RID: 17316 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000D54")]
			public override string Title
			{
				[Token(Token = "0x60043A4")]
				[Address(RVA = "0x9258", Offset = "0x9258", VA = "0x9258", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x060043A5 RID: 17317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60043A5")]
			[Address(RVA = "0x9259", Offset = "0x9259", VA = "0x9259")]
			public ByNick()
			{
			}
		}

		// Token: 0x02000AF4 RID: 2804
		[Token(Token = "0x2000AF4")]
		public class ByLevel : AbstractGameDataComparer<ChatVisitorData>
		{
			// Token: 0x060043A6 RID: 17318 RVA: 0x0000CC48 File Offset: 0x0000AE48
			[Token(Token = "0x60043A6")]
			[Address(RVA = "0x925A", Offset = "0x925A", VA = "0x925A", Slot = "8")]
			public override int Compare(ChatVisitorData x, ChatVisitorData y)
			{
				return 0;
			}

			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x060043A7 RID: 17319 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000D55")]
			public override string Title
			{
				[Token(Token = "0x60043A7")]
				[Address(RVA = "0x925B", Offset = "0x925B", VA = "0x925B", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x060043A8 RID: 17320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60043A8")]
			[Address(RVA = "0x925C", Offset = "0x925C", VA = "0x925C")]
			public ByLevel()
			{
			}
		}

		// Token: 0x02000AF5 RID: 2805
		[Token(Token = "0x2000AF5")]
		public class ByCult : AbstractGameDataComparer<ChatVisitorData>
		{
			// Token: 0x060043A9 RID: 17321 RVA: 0x0000CC60 File Offset: 0x0000AE60
			[Token(Token = "0x60043A9")]
			[Address(RVA = "0x925D", Offset = "0x925D", VA = "0x925D", Slot = "8")]
			public override int Compare(ChatVisitorData x, ChatVisitorData y)
			{
				return 0;
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x060043AA RID: 17322 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000D56")]
			public override string Title
			{
				[Token(Token = "0x60043AA")]
				[Address(RVA = "0x925E", Offset = "0x925E", VA = "0x925E", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x060043AB RID: 17323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60043AB")]
			[Address(RVA = "0x925F", Offset = "0x925F", VA = "0x925F")]
			public ByCult()
			{
			}
		}
	}
}
