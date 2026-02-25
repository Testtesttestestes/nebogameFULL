using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x020013A3 RID: 5027
	[Token(Token = "0x20013A3")]
	public static class I2Utils
	{
		// Token: 0x060077AC RID: 30636 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077AC")]
		[Address(RVA = "0xC10A", Offset = "0xC10A", VA = "0xC10A")]
		public static string ReverseText(string source)
		{
			return null;
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077AD")]
		[Address(RVA = "0xC10B", Offset = "0xC10B", VA = "0xC10B")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077AE")]
		[Address(RVA = "0xC10C", Offset = "0xC10C", VA = "0xC10C")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x60077AF")]
		[Address(RVA = "0xC10D", Offset = "0xC10D", VA = "0xC10D")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B0")]
		[Address(RVA = "0xC10E", Offset = "0xC10E", VA = "0xC10E")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x60077B1")]
		[Address(RVA = "0xC10F", Offset = "0xC10F", VA = "0xC10F")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x60077B2")]
		[Address(RVA = "0x3606", Offset = "0x3606", VA = "0x3606")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B3")]
		[Address(RVA = "0xC110", Offset = "0xC110", VA = "0xC110")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B4")]
		[Address(RVA = "0xC111", Offset = "0xC111", VA = "0xC111")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B5")]
		[Address(RVA = "0xC112", Offset = "0xC112", VA = "0xC112")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B6")]
		[Address(RVA = "0xC113", Offset = "0xC113", VA = "0xC113")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B7")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077B8")]
		[Address(RVA = "0xC114", Offset = "0xC114", VA = "0xC114")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077B9")]
		[Address(RVA = "0xC115", Offset = "0xC115", VA = "0xC115")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077BA")]
		[Address(RVA = "0xC116", Offset = "0xC116", VA = "0xC116")]
		[CompilerGenerated]
		internal static void <ReverseText>g__Reverse|3_0(int start, int end, ref I2Utils.<>c__DisplayClass3_0 A_2)
		{
		}

		// Token: 0x04003E75 RID: 15989
		[Token(Token = "0x4003E75")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		// Token: 0x04003E76 RID: 15990
		[Token(Token = "0x4003E76")]
		public const string NumberChars = "0123456789";

		// Token: 0x04003E77 RID: 15991
		[Token(Token = "0x4003E77")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";
	}
}
