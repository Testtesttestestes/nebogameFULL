using System;
using Gameplay.AccountLinker.ProgressSaver.Controller;
using Gameplay.AccountLinker.ProgressSaver.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;

namespace Gameplay.AccountLinker.ProgressSaver.WebGL.Controller
{
	// Token: 0x02000E09 RID: 3593
	[Token(Token = "0x2000E09")]
	public class ProgressSaverEnterPointFromIndexViewMediator : BaseProgressSaverEnterPointViewMediator<UserInterfaceView>
	{
		// Token: 0x06005786 RID: 22406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005786")]
		[Address(RVA = "0xA501", Offset = "0xA501", VA = "0xA501", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_AccountLinker_ProgressSaver_WebGL_Controller_ProgressSaverEnterPointFromIndexViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5892f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_UserInterfaceView___ctor__
		              );
		    DAT_ram_00a5892f = '\x01';
		  }
		  UnityEngine_UIElements_BasePopupField___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_choices
		            (param1,param2,param3,param4,
		             Method_Gameplay_AccountLinker_ProgressSaver_Controller_BaseProgressSaverEnterPointViewMediator_UserInterfaceView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005787 RID: 22407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005787")]
		[Address(RVA = "0xA502", Offset = "0xA502", VA = "0xA502")]
		public ProgressSaverEnterPointFromIndexViewMediator(ProgressSaverModel model, ProgressSaverEvents events, ProgressSaverController controller)
		{
		}

		// Token: 0x06005788 RID: 22408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005788")]
		[Address(RVA = "0xA503", Offset = "0xA503", VA = "0xA503", Slot = "21")]
		protected override void ResetView()
		{
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005789")]
		[Address(RVA = "0xA504", Offset = "0xA504", VA = "0xA504", Slot = "22")]
		protected override void SetupView()
		{
		}

		// Token: 0x0600578A RID: 22410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600578A")]
		[Address(RVA = "0xA505", Offset = "0xA505", VA = "0xA505", Slot = "23")]
		protected override void ValidateShowProgressButton()
		{
		}
	}
}
