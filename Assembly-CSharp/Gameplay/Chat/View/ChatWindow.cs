using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Chat.View
{
	// Token: 0x02000AEF RID: 2799
	[Token(Token = "0x2000AEF")]
	public class ChatWindow : ClosableBaseWindow<ChatWindow.ChatWindowArgs>
	{
		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D50")]
		public override string WindowId
		{
			[Token(Token = "0x600438A")]
			[Address(RVA = "0x923E", Offset = "0x923E", VA = "0x923E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438B")]
		[Address(RVA = "0x923F", Offset = "0x923F", VA = "0x923F")]
		public ChatWindow()
		{
		}

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Chat/ChatWindow";

		// Token: 0x02000AF0 RID: 2800
		[Token(Token = "0x2000AF0")]
		public class ChatWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600438C RID: 17292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600438C")]
			[Address(RVA = "0x9240", Offset = "0x9240", VA = "0x9240")]
			public ChatWindowArgs()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Chat_View_ChatWindow__get_WindowId(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57aed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_ChatWindow_ChatWindowArgs___ctor__);
		    DAT_ram_00a57aed = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_ChatWindow_ChatWindowArgs___ctor__);
		  return;
		}
		*/

}
