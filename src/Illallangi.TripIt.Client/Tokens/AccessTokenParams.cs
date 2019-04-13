using Refit;

namespace Illallangi.TripIt.Tokens
{
    public sealed class AccessTokenParams
    {
        /// <summary>
        /// The Consumer's public key.
        /// </summary>
        [AliasAs(@"oauth_consumer_key")]
        public string ConsumerKey { get; set; }
        
        /// <summary>
        /// The request token previously obtained.
        /// </summary>
        [AliasAs(@"oauth_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// The request token secret previously obtained.
        /// </summary>
        [AliasAs(@"oauth_token_secret")]
        public string RequestTokenSecret { get; set; }

        /// <summary>
        /// The method used to generate the method signature.Current supported methods are HMAC-SHA1.
        /// </summary>
        [AliasAs(@"oauth_signature_method")]
        public string SignatureMethod => OAuthHmacSha1SigningHandler.SignatureMethodPlaceholder;

        /// <summary>
        /// The signature of the request. The algorithm to sign the request is described in the OAuth specification and examples can be found in the reference implementations.
        /// </summary>
        [AliasAs(@"oauth_signature")]
        public string Signature => OAuthHmacSha1SigningHandler.SignaturePlaceholder;

        /// <summary>
        /// The timestamp in seconds since the epoch given in UTC.Note that the server will respond with a 401 (unauthorized) if the timestamp supplied by the client is more than +/- 3 hours from what the server considers the current time.
        /// </summary>
        [AliasAs(@"oauth_timestamp")]
        public string Timestamp => OAuthHmacSha1SigningHandler.TimestampPlaceholder;

        /// <summary>
        /// A nonce no more than 80 characters in length.
        /// </summary>
        [AliasAs(@"oauth_nonce")]
        public string Nonce => OAuthHmacSha1SigningHandler.NoncePlaceholder;

        /// <summary>
        /// OPTIONAL - Assumed to be '1.0'
        /// </summary>
        [AliasAs(@"oauth_version")]
        public string Version => OAuthHmacSha1SigningHandler.VersionPlaceholder;
    }
}