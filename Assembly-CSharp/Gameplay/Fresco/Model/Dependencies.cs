using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Controller;
using Gameplay.Collections.Controller;
using Gameplay.GdEvents.Control;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Fresco.Model
{
	// Token: 0x02000802 RID: 2050
	[Token(Token = "0x2000802")]
	public class Dependencies
	{
		// Token: 0x06003013 RID: 12307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003013")]
		[Address(RVA = "0x8078", Offset = "0x8078", VA = "0x8078")]
		public Dependencies(PopupController popupController, CollectionsController collectionsController, IDictProvider dictProvider, BankController bankController, GdEventsController gdEventsController, UserData user, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Model_Dependencies___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63aba == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_ChangedFromTo_OwnerRating__TypeInfo);
		    DAT_ram_00a63aba = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = Core_ChangedFromTo_OwnerRating__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,Core_ChangedFromTo_OwnerRating__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001A55 RID: 6741
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x8")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001A56 RID: 6742
		[Token(Token = "0x4001A56")]
		[FieldOffset(Offset = "0xC")]
		public readonly PopupController PopupController;

		// Token: 0x04001A57 RID: 6743
		[Token(Token = "0x4001A57")]
		[FieldOffset(Offset = "0x10")]
		public readonly CollectionsController CollectionsController;

		// Token: 0x04001A58 RID: 6744
		[Token(Token = "0x4001A58")]
		[FieldOffset(Offset = "0x14")]
		public readonly BankController BankController;

		// Token: 0x04001A59 RID: 6745
		[Token(Token = "0x4001A59")]
		[FieldOffset(Offset = "0x18")]
		public readonly GdEventsController GdEventsController;

		// Token: 0x04001A5A RID: 6746
		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x1C")]
		public readonly UserData User;

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x20")]
		public readonly IGame Game;
	}
}
