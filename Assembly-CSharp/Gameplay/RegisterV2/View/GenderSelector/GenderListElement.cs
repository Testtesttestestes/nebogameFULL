using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements.GenericList;

namespace Gameplay.RegisterV2.View.GenderSelector
{
	// Token: 0x02000562 RID: 1378
	[Token(Token = "0x2000562")]
	public class GenderListElement : SelectableListElement<GenderListElement.GenderListElementArgs>
	{
		// Token: 0x06002146 RID: 8518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002146")]
		[Address(RVA = "0x72A8", Offset = "0x72A8", VA = "0x72A8", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x72A9", Offset = "0x72A9", VA = "0x72A9", Slot = "10")]
		protected override void CallElementClickedEvent(GenderListElement.GenderListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_RegisterV2_View_GenderSelector_GenderListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58377 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_GenderListElement_GenderListElementArgs___ctor__
		              );
		    DAT_ram_00a58377 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_GenderListElement_GenderListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x72AA", Offset = "0x72AA", VA = "0x72AA")]
		public GenderListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_GenderSelector_GenderListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58378 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_GenericList_SelectableListElementArgs_GenderListElement___ctor__)
		    ;
		    DAT_ram_00a58378 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_GenderListElement___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x02000563 RID: 1379
		[Token(Token = "0x2000563")]
		public class GenderListElementArgs : SelectableListElementArgs<GenderListElement>
		{
			// Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002149")]
			[Address(RVA = "0x72AB", Offset = "0x72AB", VA = "0x72AB")]
			public GenderListElementArgs()
			{
			}

			// Token: 0x0400122F RID: 4655
			[Token(Token = "0x400122F")]
			[FieldOffset(Offset = "0x1C")]
			public AprDic AprDic;
		}
	}
}
