using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events
{
	// Token: 0x02000FB7 RID: 4023
	[Token(Token = "0x2000FB7")]
	public class BaseEventBusEventArgs : EventArgs
	{
		// Token: 0x06006025 RID: 24613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006025")]
		[Address(RVA = "0x227B", Offset = "0x227B", VA = "0x227B")]
		public BaseEventBusEventArgs(IApp app, IGame game)
		{
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006027 RID: 24615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D2")]
		public IApp App
		{
			[Token(Token = "0x6006026")]
			[Address(RVA = "0xAC53", Offset = "0xAC53", VA = "0xAC53")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006027")]
			[Address(RVA = "0xAC54", Offset = "0xAC54", VA = "0xAC54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06006028 RID: 24616 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006029 RID: 24617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170012D3")]
		public IGame Game
		{
			[Token(Token = "0x6006028")]
			[Address(RVA = "0xAC55", Offset = "0xAC55", VA = "0xAC55")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006029")]
			[Address(RVA = "0xAC56", Offset = "0xAC56", VA = "0xAC56")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600602A")]
		[Address(RVA = "0xAC57", Offset = "0xAC57", VA = "0xAC57", Slot = "4")]
		public virtual Dictionary<string, object> GetEventProperties()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Game ---
		undefined4 Core_Events_BaseEventBusEventArgs__set_Game(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a349 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__object__TypeInfo);
		    DAT_ram_00a5a349 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__object__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__object___ctor__);
		  return param1_00;
		}
		*/

}
