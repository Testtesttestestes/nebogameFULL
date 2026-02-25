using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Analytics.Okg.Data;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace Core.Analytics.Okg
{
	// Token: 0x020012A1 RID: 4769
	[Token(Token = "0x20012A1")]
	public class OkgAnalytics : IOkgAnalytics, IDisposable
	{
		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600714D RID: 29005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700170C")]
		public static IOkgAnalytics Instance
		{
			[Token(Token = "0x600714D")]
			[Address(RVA = "0xBB68", Offset = "0xBB68", VA = "0xBB68")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600714E")]
		[Address(RVA = "0xBB69", Offset = "0xBB69", VA = "0xBB69")]
		public OkgAnalytics(bool restoreUserId = true, bool restoreUserLevel = true, bool restoreEventTimestamps = true, bool restoreIsTempUserId = true)
		{
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600714F")]
		[Address(RVA = "0xBB6A", Offset = "0xBB6A", VA = "0xBB6A", Slot = "4")]
		public void LogEvent(OkgAnalyticsData eventHeader, IReadOnlyDictionary<string, object> data)
		{
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007150")]
		[Address(RVA = "0xBB6B", Offset = "0xBB6B", VA = "0xBB6B", Slot = "5")]
		public void SetUserId(long userId)
		{
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007151")]
		[Address(RVA = "0xBB6C", Offset = "0xBB6C", VA = "0xBB6C", Slot = "6")]
		public void SetUserLevel(int userLevel)
		{
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x000149A0 File Offset: 0x00012BA0
		[Token(Token = "0x6007152")]
		[Address(RVA = "0xBB6D", Offset = "0xBB6D", VA = "0xBB6D", Slot = "8")]
		public bool SetServerTimeOffset(long deltaTimeMs)
		{
			return default(bool);
		}

		// Token: 0x06007153 RID: 29011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007153")]
		[Address(RVA = "0xBB6E", Offset = "0xBB6E", VA = "0xBB6E", Slot = "7")]
		public void SetIsTempUserFlag(bool isTempUser)
		{
		}

		// Token: 0x06007154 RID: 29012 RVA: 0x000149B8 File Offset: 0x00012BB8
		[Token(Token = "0x6007154")]
		[Address(RVA = "0xBB6F", Offset = "0xBB6F", VA = "0xBB6F")]
		public static Build GetBuild(string version)
		{
			return Build.undefined;
		}

		// Token: 0x06007155 RID: 29013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007155")]
		[Address(RVA = "0xBB70", Offset = "0xBB70", VA = "0xBB70", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x06007156 RID: 29014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007156")]
		[Address(RVA = "0x1E8E", Offset = "0x1E8E", VA = "0x1E8E")]
		private static string GetLogPath()
		{
			return null;
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007157")]
		[Address(RVA = "0xBB71", Offset = "0xBB71", VA = "0xBB71")]
		private void Initialize()
		{
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007158")]
		[Address(RVA = "0xBB72", Offset = "0xBB72", VA = "0xBB72")]
		private void ApplicationFocusHandler(bool hasFocus)
		{
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007159")]
		[Address(RVA = "0xBB73", Offset = "0xBB73", VA = "0xBB73")]
		private void ApplicationQuitHandler()
		{
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x0600715A RID: 29018 RVA: 0x000149D0 File Offset: 0x00012BD0
		[Token(Token = "0x1700170D")]
		private bool IsAuthorizedUser
		{
			[Token(Token = "0x600715A")]
			[Address(RVA = "0x1E84", Offset = "0x1E84", VA = "0x1E84")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600715B RID: 29019 RVA: 0x000149E8 File Offset: 0x00012BE8
		[Token(Token = "0x600715B")]
		[Address(RVA = "0x1E9A", Offset = "0x1E9A", VA = "0x1E9A")]
		private UniTask<string> GetToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600715C RID: 29020 RVA: 0x00014A00 File Offset: 0x00012C00
		[Token(Token = "0x600715C")]
		[Address(RVA = "0x1E85", Offset = "0x1E85", VA = "0x1E85")]
		private UniTask<string> RequireToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600715D RID: 29021 RVA: 0x00014A18 File Offset: 0x00012C18
		[Token(Token = "0x600715D")]
		[Address(RVA = "0x1E87", Offset = "0x1E87", VA = "0x1E87")]
		private UniTask<string> CreateTempToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600715E RID: 29022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600715E")]
		[Address(RVA = "0xBB74", Offset = "0xBB74", VA = "0xBB74")]
		private IEnumerable<byte> GetByteIterator([TupleElementNames(new string[]
		{
			"bytes",
			"len"
		})] IReadOnlyList<ValueTuple<byte[], int>> bytes)
		{
			return null;
		}

		// Token: 0x0600715F RID: 29023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600715F")]
		[Address(RVA = "0xBB75", Offset = "0xBB75", VA = "0xBB75")]
		private void ValidateLogBuilder()
		{
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007160")]
		[Address(RVA = "0xBB76", Offset = "0xBB76", VA = "0xBB76")]
		private void DoLogEvent(OkgAnalyticsData dataBlock)
		{
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x6007161")]
		[Address(RVA = "0xBB77", Offset = "0xBB77", VA = "0xBB77")]
		private UniTask ApplyLog()
		{
			return default(UniTask);
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x6007162")]
		[Address(RVA = "0x1E91", Offset = "0x1E91", VA = "0x1E91")]
		private UniTask<bool> SendLog(byte[] rawLog)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06007163 RID: 29027 RVA: 0x00014A60 File Offset: 0x00012C60
		[Token(Token = "0x6007163")]
		[Address(RVA = "0x1E9D", Offset = "0x1E9D", VA = "0x1E9D")]
		private UniTask<bool> DoSendLog(byte[] rawLog)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06007164 RID: 29028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007164")]
		[Address(RVA = "0xBB78", Offset = "0xBB78", VA = "0xBB78")]
		private void ApplySendLogResult(UnityWebRequestAsyncOperation operation, byte[] rawLog, string token)
		{
		}

		// Token: 0x06007165 RID: 29029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007165")]
		[Address(RVA = "0xBB79", Offset = "0xBB79", VA = "0xBB79")]
		private void UpdateTokenAndSendLogAgain(byte[] rawLog)
		{
		}

		// Token: 0x04003B1D RID: 15133
		[Token(Token = "0x4003B1D")]
		private const string AnonymousTokenSecret = "d058713ac7";

		// Token: 0x04003B1E RID: 15134
		[Token(Token = "0x4003B1E")]
		[FieldOffset(Offset = "0x0")]
		private static IOkgAnalytics _instance;

		// Token: 0x04003B1F RID: 15135
		[Token(Token = "0x4003B1F")]
		private const string LogFileName = "okg_analytics.log";

		// Token: 0x04003B20 RID: 15136
		[Token(Token = "0x4003B20")]
		private const long LogFileSizeLimit = 1048576L;

		// Token: 0x04003B21 RID: 15137
		[Token(Token = "0x4003B21")]
		private const int MaxUpdateTokenIterations = 1;

		// Token: 0x04003B22 RID: 15138
		[Token(Token = "0x4003B22")]
		private const long SendDataDelayTimeSeconds = 30L;

		// Token: 0x04003B23 RID: 15139
		[Token(Token = "0x4003B23")]
		private const double SendDataTimeSeconds = 180.0;

		// Token: 0x04003B24 RID: 15140
		[Token(Token = "0x4003B24")]
		[FieldOffset(Offset = "0x8")]
		private bool _invalidate;

		// Token: 0x04003B25 RID: 15141
		[Token(Token = "0x4003B25")]
		[FieldOffset(Offset = "0xC")]
		private ILogBuilder _log;

		// Token: 0x04003B26 RID: 15142
		[Token(Token = "0x4003B26")]
		[FieldOffset(Offset = "0x10")]
		private OkgAnalytics.ActualFlag _actualFlag;

		// Token: 0x04003B27 RID: 15143
		[Token(Token = "0x4003B27")]
		[FieldOffset(Offset = "0x14")]
		private string _token;

		// Token: 0x04003B28 RID: 15144
		[Token(Token = "0x4003B28")]
		[FieldOffset(Offset = "0x18")]
		private string _tempToken;

		// Token: 0x04003B29 RID: 15145
		[Token(Token = "0x4003B29")]
		[FieldOffset(Offset = "0x1C")]
		private bool _getTokenInProcess;

		// Token: 0x04003B2A RID: 15146
		[Token(Token = "0x4003B2A")]
		[FieldOffset(Offset = "0x1D")]
		private bool _getTempTokenInProcess;

		// Token: 0x04003B2B RID: 15147
		[Token(Token = "0x4003B2B")]
		[FieldOffset(Offset = "0x20")]
		private UniTaskCompletionSource<string> _getTokenCompletion;

		// Token: 0x04003B2C RID: 15148
		[Token(Token = "0x4003B2C")]
		[FieldOffset(Offset = "0x24")]
		private UniTaskCompletionSource<bool> _sendDataCompletion;

		// Token: 0x04003B2D RID: 15149
		[Token(Token = "0x4003B2D")]
		[FieldOffset(Offset = "0x28")]
		private long _sendDataTimestamp;

		// Token: 0x04003B2E RID: 15150
		[Token(Token = "0x4003B2E")]
		[FieldOffset(Offset = "0x30")]
		private int _updateTokenIterations;

		// Token: 0x04003B2F RID: 15151
		[Token(Token = "0x4003B2F")]
		[FieldOffset(Offset = "0x34")]
		private bool _isInitialized;

		// Token: 0x04003B30 RID: 15152
		[Token(Token = "0x4003B30")]
		[FieldOffset(Offset = "0x38")]
		private DateTime _lastEventTs;

		// Token: 0x04003B31 RID: 15153
		[Token(Token = "0x4003B31")]
		[FieldOffset(Offset = "0x40")]
		private readonly Lazy<string> _url;

		// Token: 0x04003B32 RID: 15154
		[Token(Token = "0x4003B32")]
		[FieldOffset(Offset = "0x44")]
		private readonly bool _restoreUserId;

		// Token: 0x04003B33 RID: 15155
		[Token(Token = "0x4003B33")]
		[FieldOffset(Offset = "0x45")]
		private readonly bool _restoreUserLevel;

		// Token: 0x04003B34 RID: 15156
		[Token(Token = "0x4003B34")]
		[FieldOffset(Offset = "0x46")]
		private readonly bool _restoreEventTimestamps;

		// Token: 0x04003B35 RID: 15157
		[Token(Token = "0x4003B35")]
		[FieldOffset(Offset = "0x47")]
		private readonly bool _restoreIsTempUserId;

		// Token: 0x020012A2 RID: 4770
		[Token(Token = "0x20012A2")]
		[Flags]
		private enum ActualFlag
		{
			// Token: 0x04003B37 RID: 15159
			[Token(Token = "0x4003B37")]
			NothingActual = 0,
			// Token: 0x04003B38 RID: 15160
			[Token(Token = "0x4003B38")]
			UserId = 1,
			// Token: 0x04003B39 RID: 15161
			[Token(Token = "0x4003B39")]
			Level = 2,
			// Token: 0x04003B3A RID: 15162
			[Token(Token = "0x4003B3A")]
			Time = 4,
			// Token: 0x04003B3B RID: 15163
			[Token(Token = "0x4003B3B")]
			IsTempId = 8,
			// Token: 0x04003B3C RID: 15164
			[Token(Token = "0x4003B3C")]
			AllActual = 15
		}
	}
}
