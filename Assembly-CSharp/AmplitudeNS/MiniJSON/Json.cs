using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace AmplitudeNS.MiniJSON
{
	// Token: 0x020013E5 RID: 5093
	[Token(Token = "0x20013E5")]
	public static class Json
	{
		// Token: 0x06007982 RID: 31106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007982")]
		[Address(RVA = "0xC261", Offset = "0xC261", VA = "0xC261")]
		public static object Deserialize(string json)
		{
			return null;
		}

		// Token: 0x06007983 RID: 31107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007983")]
		[Address(RVA = "0xC262", Offset = "0xC262", VA = "0xC262")]
		public static string Serialize(object obj)
		{
			return null;
		}

		// Token: 0x020013E6 RID: 5094
		[Token(Token = "0x20013E6")]
		private sealed class Parser : IDisposable
		{
			// Token: 0x06007984 RID: 31108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007984")]
			[Address(RVA = "0xC263", Offset = "0xC263", VA = "0xC263")]
			private Parser(string jsonString)
			{
			}

			// Token: 0x06007985 RID: 31109 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007985")]
			[Address(RVA = "0xC264", Offset = "0xC264", VA = "0xC264")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			// Token: 0x06007986 RID: 31110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007986")]
			[Address(RVA = "0xC265", Offset = "0xC265", VA = "0xC265", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06007987 RID: 31111 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007987")]
			[Address(RVA = "0xC266", Offset = "0xC266", VA = "0xC266")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			// Token: 0x06007988 RID: 31112 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007988")]
			[Address(RVA = "0xC267", Offset = "0xC267", VA = "0xC267")]
			private List<object> ParseArray()
			{
				return null;
			}

			// Token: 0x06007989 RID: 31113 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007989")]
			[Address(RVA = "0xC268", Offset = "0xC268", VA = "0xC268")]
			private object ParseValue()
			{
				return null;
			}

			// Token: 0x0600798A RID: 31114 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600798A")]
			[Address(RVA = "0x1911", Offset = "0x1911", VA = "0x1911")]
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				return null;
			}

			// Token: 0x0600798B RID: 31115 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600798B")]
			[Address(RVA = "0xC269", Offset = "0xC269", VA = "0xC269")]
			private string ParseString()
			{
				return null;
			}

			// Token: 0x0600798C RID: 31116 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600798C")]
			[Address(RVA = "0xC26A", Offset = "0xC26A", VA = "0xC26A")]
			private object ParseNumber()
			{
				return null;
			}

			// Token: 0x0600798D RID: 31117 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600798D")]
			[Address(RVA = "0xC26B", Offset = "0xC26B", VA = "0xC26B")]
			private void EatWhitespace()
			{
			}

			// Token: 0x17001802 RID: 6146
			// (get) Token: 0x0600798E RID: 31118 RVA: 0x000165D8 File Offset: 0x000147D8
			[Token(Token = "0x17001802")]
			private char PeekChar
			{
				[Token(Token = "0x600798E")]
				[Address(RVA = "0xC26C", Offset = "0xC26C", VA = "0xC26C")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17001803 RID: 6147
			// (get) Token: 0x0600798F RID: 31119 RVA: 0x000165F0 File Offset: 0x000147F0
			[Token(Token = "0x17001803")]
			private char NextChar
			{
				[Token(Token = "0x600798F")]
				[Address(RVA = "0xC26D", Offset = "0xC26D", VA = "0xC26D")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17001804 RID: 6148
			// (get) Token: 0x06007990 RID: 31120 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001804")]
			private string NextWord
			{
				[Token(Token = "0x6007990")]
				[Address(RVA = "0xC26E", Offset = "0xC26E", VA = "0xC26E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001805 RID: 6149
			// (get) Token: 0x06007991 RID: 31121 RVA: 0x00016608 File Offset: 0x00014808
			[Token(Token = "0x17001805")]
			private Json.Parser.TOKEN NextToken
			{
				[Token(Token = "0x6007991")]
				[Address(RVA = "0x1910", Offset = "0x1910", VA = "0x1910")]
				get
				{
					return Json.Parser.TOKEN.NONE;
				}
			}

			// Token: 0x04003F5F RID: 16223
			[Token(Token = "0x4003F5F")]
			private const string WHITE_SPACE = " \t\n\r";

			// Token: 0x04003F60 RID: 16224
			[Token(Token = "0x4003F60")]
			private const string WORD_BREAK = " \t\n\r{}[],:\"";

			// Token: 0x04003F61 RID: 16225
			[Token(Token = "0x4003F61")]
			[FieldOffset(Offset = "0x8")]
			private StringReader json;

			// Token: 0x020013E7 RID: 5095
			[Token(Token = "0x20013E7")]
			private enum TOKEN
			{
				// Token: 0x04003F63 RID: 16227
				[Token(Token = "0x4003F63")]
				NONE,
				// Token: 0x04003F64 RID: 16228
				[Token(Token = "0x4003F64")]
				CURLY_OPEN,
				// Token: 0x04003F65 RID: 16229
				[Token(Token = "0x4003F65")]
				CURLY_CLOSE,
				// Token: 0x04003F66 RID: 16230
				[Token(Token = "0x4003F66")]
				SQUARED_OPEN,
				// Token: 0x04003F67 RID: 16231
				[Token(Token = "0x4003F67")]
				SQUARED_CLOSE,
				// Token: 0x04003F68 RID: 16232
				[Token(Token = "0x4003F68")]
				COLON,
				// Token: 0x04003F69 RID: 16233
				[Token(Token = "0x4003F69")]
				COMMA,
				// Token: 0x04003F6A RID: 16234
				[Token(Token = "0x4003F6A")]
				STRING,
				// Token: 0x04003F6B RID: 16235
				[Token(Token = "0x4003F6B")]
				NUMBER,
				// Token: 0x04003F6C RID: 16236
				[Token(Token = "0x4003F6C")]
				TRUE,
				// Token: 0x04003F6D RID: 16237
				[Token(Token = "0x4003F6D")]
				FALSE,
				// Token: 0x04003F6E RID: 16238
				[Token(Token = "0x4003F6E")]
				NULL
			}
		}

		// Token: 0x020013E8 RID: 5096
		[Token(Token = "0x20013E8")]
		private sealed class Serializer
		{
			// Token: 0x06007992 RID: 31122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007992")]
			[Address(RVA = "0xC26F", Offset = "0xC26F", VA = "0xC26F")]
			private Serializer()
			{
			}

			// Token: 0x06007993 RID: 31123 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6007993")]
			[Address(RVA = "0xC270", Offset = "0xC270", VA = "0xC270")]
			public static string Serialize(object obj)
			{
				return null;
			}

			// Token: 0x06007994 RID: 31124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007994")]
			[Address(RVA = "0x1913", Offset = "0x1913", VA = "0x1913")]
			private void SerializeValue(object value)
			{
			}

			// Token: 0x06007995 RID: 31125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007995")]
			[Address(RVA = "0xC271", Offset = "0xC271", VA = "0xC271")]
			private void SerializeObject(IDictionary obj)
			{
			}

			// Token: 0x06007996 RID: 31126 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007996")]
			[Address(RVA = "0xC272", Offset = "0xC272", VA = "0xC272")]
			private void SerializeArray(IList anArray)
			{
			}

			// Token: 0x06007997 RID: 31127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007997")]
			[Address(RVA = "0x1915", Offset = "0x1915", VA = "0x1915")]
			private void SerializeString(string str)
			{
			}

			// Token: 0x06007998 RID: 31128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007998")]
			[Address(RVA = "0xC273", Offset = "0xC273", VA = "0xC273")]
			private void SerializeOther(object value)
			{
			}

			// Token: 0x04003F6F RID: 16239
			[Token(Token = "0x4003F6F")]
			[FieldOffset(Offset = "0x8")]
			private StringBuilder builder;
		}
	}
}
