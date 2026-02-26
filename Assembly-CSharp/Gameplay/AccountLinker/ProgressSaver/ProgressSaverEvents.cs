using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.AccountLinker.ProgressSaver
{
	// Token: 0x02000E08 RID: 3592
	[Token(Token = "0x2000E08")]
	public class ProgressSaverEvents : AbstractMVCEvents
	{
		// Token: 0x06005785 RID: 22405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005785")]
		[Address(RVA = "0xA500", Offset = "0xA500", VA = "0xA500")]
		public ProgressSaverEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_ProgressSaver_ProgressSaverEvents___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5892e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_UserInterfaceView__CloseProgressSaverWindow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_UserInterfaceView__Dispose__
		              );
		    DAT_ram_00a5892e = '\x01';
		  }
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object____ctor
		            (param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_UserInterfaceView__CloseProgressSaverWindow__
		            );
		  Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_object___CloseProgressSaverWindow
		            (param1,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_UserInterfaceView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002F73 RID: 12147
		[Token(Token = "0x4002F73")]
		[FieldOffset(Offset = "0x14")]
		public Action SetEmailPasswordSuccessEvent;

		// Token: 0x04002F74 RID: 12148
		[Token(Token = "0x4002F74")]
		[FieldOffset(Offset = "0x18")]
		public Action ProgressSavedSuccessEvent;
	}
}
