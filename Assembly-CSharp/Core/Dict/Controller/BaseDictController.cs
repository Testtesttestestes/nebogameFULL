using System;
using System.Collections;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Core.Dict.Model;
using Core.Files;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using UnityEngine;

namespace Core.Dict.Controller
{
	// Token: 0x020010A4 RID: 4260
	[Token(Token = "0x20010A4")]
	public class BaseDictController : AbstractController<DictModel, DictEvents>
	{
		// Token: 0x060062FD RID: 25341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0xAF0B", Offset = "0xAF0B", VA = "0xAF0B", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0xAF0C", Offset = "0xAF0C", VA = "0xAF0C")]
		public BaseDictController(DictModel model, DictEvents events)
		{
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FF")]
		[Address(RVA = "0xAF0D", Offset = "0xAF0D", VA = "0xAF0D", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06006300 RID: 25344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006300")]
		[Address(RVA = "0xAF0E", Offset = "0xAF0E", VA = "0xAF0E")]
		private void AuthManagerOnDictionaryNameChangedEvent(IDictNameSource source)
		{
		}

		// Token: 0x06006301 RID: 25345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006301")]
		[Address(RVA = "0xAF0F", Offset = "0xAF0F", VA = "0xAF0F", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06006302 RID: 25346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006302")]
		[Address(RVA = "0x36DC", Offset = "0x36DC", VA = "0x36DC")]
		private void LoadDict(string path)
		{
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006303")]
		[Address(RVA = "0xAF10", Offset = "0xAF10", VA = "0xAF10")]
		private void ParseResultDic(IFileContent content)
		{
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006304")]
		[Address(RVA = "0xAF11", Offset = "0xAF11", VA = "0xAF11", Slot = "12")]
		protected virtual byte[] DecompressData(IFileContent content, byte[] compressedData)
		{
			return null;
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006305")]
		[Address(RVA = "0xAF12", Offset = "0xAF12", VA = "0xAF12")]
		private IEnumerator ProcessDictionaries(byte[] resultBytes)
		{
			return null;
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6006306")]
		[Address(RVA = "0xAF13", Offset = "0xAF13", VA = "0xAF13")]
		private bool MyRemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x18")]
		private bool _disposed;

		// Token: 0x04003517 RID: 13591
		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _processDictionariesCoroutine;
	}
}
